using Application.Interfaces.Server.Auth;
using Application.Interfaces.Server.Cart;
using Common.ServiceResponse;
using Domain.Entities.Cart;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Application.Services.Server.Cart
{
    public class CartService : ICartService
    {
        private readonly DataBaseContext _context;
        private readonly IAuthService _authService;
        public CartService(DataBaseContext context, IAuthService authService)
        {
            _context = context;
            _authService = authService;
        }

        public async Task<ResultDto<List<CartProductResponse>>> GetCartProducts(List<CartItem> cartItems)
        {
            var result = new ResultDto<List<CartProductResponse>>
            {
                Data = new List<CartProductResponse>()
            };

            foreach (var item in cartItems)
            {
                var product = await _context.Products
                    .Where(p => p.Id == item.ProductId)
                    .FirstOrDefaultAsync();

                if (product == null)
                {
                    continue;
                }

                var productVariant = await _context.ProductVariants
                    .Where(v => v.ProductId == item.ProductId
                        && v.ProductTypeId == item.ProductTypeId)
                    .Include(v => v.ProductType)
                    .FirstOrDefaultAsync();

                if (productVariant == null)
                {
                    continue;
                }

                var cartProduct = new CartProductResponse
                {
                    ProductId = product.Id,
                    Name = product.Name,
                    ImageUrl = product.ImageUrl,
                    Price = productVariant.Price,
                    ProductType = productVariant.ProductType.Name,
                    ProductTypeId = productVariant.ProductTypeId,
                    Quantity = item.Quantity
                };

                result.Data.Add(cartProduct);
            }

            return result;
        }

        public async Task<ResultDto<List<CartProductResponse>>> StoreCartItems(List<CartItem> cartItems)
        {
            cartItems.ForEach(cartItem => cartItem.UserId = _authService.GetUserId());
            _context.CartItems.AddRange(cartItems);
            await _context.SaveChangesAsync();

            return await GetDbCartProducts();
        }

        public async Task<ResultDto<int>> GetCartItemsCount()
        {
            var count = (await _context.CartItems.Where(ci => ci.UserId == _authService.GetUserId()).ToListAsync()).Count;
            return new ResultDto<int> { Data = count };
        }

        public async Task<ResultDto<List<CartProductResponse>>> GetDbCartProducts(int? userId = null)
        {
            if (userId == null)
                userId = _authService.GetUserId();
            return await GetCartProducts(await _context.CartItems
                .Where(ci => ci.UserId == userId).ToListAsync());
        }

        public async Task<ResultDto<bool>> AddToCart(CartItem cartItem)
        {
            cartItem.UserId = _authService.GetUserId();

            var sameItem = await _context.CartItems
                .FirstOrDefaultAsync(ci => ci.ProductId == cartItem.ProductId &&
                ci.ProductTypeId == cartItem.ProductTypeId && ci.UserId == cartItem.UserId);
            if (sameItem == null)
            {
                _context.CartItems.Add(cartItem);
            }
            else
            {
                sameItem.Quantity += cartItem.Quantity;
            }

            await _context.SaveChangesAsync();

            return new ResultDto<bool> { Data = true };
        }

        public async Task<ResultDto<bool>> UpdateQuantity(CartItem cartItem)
        {
            var dbCartItem = await _context.CartItems
                .FirstOrDefaultAsync(ci => ci.ProductId == cartItem.ProductId &&
                ci.ProductTypeId == cartItem.ProductTypeId && ci.UserId == _authService.GetUserId());
            if (dbCartItem == null)
            {
                return new ResultDto<bool>
                {
                    Data = false,
                    IsSuccess = false,
                    Message = "Cart item does not exist."
                };
            }

            dbCartItem.Quantity = cartItem.Quantity;
            await _context.SaveChangesAsync();

            return new ResultDto<bool> { Data = true };
        }

        public async Task<ResultDto<bool>> RemoveItemFromCart(int productId, int productTypeId)
        {
            var dbCartItem = await _context.CartItems
                .FirstOrDefaultAsync(ci => ci.ProductId == productId &&
                ci.ProductTypeId == productTypeId && ci.UserId == _authService.GetUserId());
            if (dbCartItem == null)
            {
                return new ResultDto<bool>
                {
                    Data = false,
                    IsSuccess = false,
                    Message = "Cart item does not exist."
                };
            }

            _context.CartItems.Remove(dbCartItem);
            await _context.SaveChangesAsync();

            return new ResultDto<bool> { Data = true };
        }
    }

}
