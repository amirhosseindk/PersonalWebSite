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

        public CartService(DataBaseContext context)
        {
            _context = context;
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
    }
}
