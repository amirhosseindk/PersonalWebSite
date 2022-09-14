using Application.Interfaces.Server.Auth;
using Application.Interfaces.Server.Cart;
using Application.Interfaces.Server.Order;
using Common.ServiceResponse;
using Domain.Entities.Order;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Application.Services.Server.Order
{
    public class OrderService : IOrderService
    {
        private readonly DataBaseContext _context;
        private readonly ICartService _cartService;
        private readonly IAuthService _authService;

        public OrderService(DataBaseContext context,
            ICartService cartService,
            IAuthService authService)
        {
            _context = context;
            _cartService = cartService;
            _authService = authService;
        }

        public async Task<ResultDto<OrderDetailsResponse>> GetOrderDetails(int orderId)
        {
            var response = new ResultDto<OrderDetailsResponse>();
            var order = await _context.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.ProductType)
                .Where(o => o.UserId == _authService.GetUserId() && o.Id == orderId)
                .OrderByDescending(o => o.InsertTime)
                .FirstOrDefaultAsync();

            if (order == null)
            {
                response.IsSuccess = false;
                response.Message = "Order not found.";
                return response;
            }

            var orderDetailsResponse = new OrderDetailsResponse
            {
                OrderDate = order.InsertTime,
                TotalPrice = order.TotalPrice,
                Products = new List<OrderDetailsProductResponse>()
            };

            order.OrderItems.ForEach(item =>
            orderDetailsResponse.Products.Add(new OrderDetailsProductResponse
            {
                ProductId = item.ProductId,
                ImageUrl = item.Product.ImageUrl,
                ProductType = item.ProductType.Name,
                Quantity = item.Quantity,
                Name = item.Product.Name,
                TotalPrice = item.TotalPrice
            }));

            response.Data = orderDetailsResponse;

            return response;
        }

        public async Task<ResultDto<List<OrderOverviewResponse>>> GetOrders()
        {
            var response = new ResultDto<List<OrderOverviewResponse>>();
            var orders = await _context.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
                .Where(o => o.UserId == _authService.GetUserId())
                .OrderByDescending(o => o.InsertTime)
                .ToListAsync();

            var orderResponse = new List<OrderOverviewResponse>();
            orders.ForEach(o => orderResponse.Add(new OrderOverviewResponse
            {
                Id = o.Id,
                InsertTime = o.InsertTime,
                TotalPrice = o.TotalPrice,
                Product = o.OrderItems.Count > 1 ?
                    $"{o.OrderItems.First().Product.Name} and" +
                    $" {o.OrderItems.Count - 1} more..." :
                    o.OrderItems.First().Product.Name,
                ProductImageUrl = o.OrderItems.First().Product.ImageUrl
            }));

            response.Data = orderResponse;

            return response;
        }

        public async Task<ResultDto<bool>> PlaceOrder(int userId)
        {
            var products = (await _cartService.GetDbCartProducts(userId)).Data;
            decimal totalPrice = 0;
            products.ForEach(product => totalPrice += product.Price * product.Quantity);

            var orderItems = new List<OrderItem>();
            products.ForEach(product => orderItems.Add(new OrderItem
            {
                ProductId = product.ProductId,
                ProductTypeId = product.ProductTypeId,
                Quantity = product.Quantity,
                TotalPrice = product.Price * product.Quantity
            }));

            var order = new Domain.Entities.Order.Order
            {
                UserId = userId,
                InsertTime = DateTime.Now,
                TotalPrice = totalPrice,
                OrderItems = orderItems
            };

            _context.Orders.Add(order);

            _context.CartItems.RemoveRange(_context.CartItems
                .Where(ci => ci.UserId == userId));

            await _context.SaveChangesAsync();

            return new ResultDto<bool> { Data = true , IsSuccess = true , Message = "Success"};
        }
    }
}
