using Common.ServiceResponse;
using Domain.Entities.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Server.Cart
{
    public interface ICartService
    {
        Task<ResultDto<List<CartProductResponse>>> GetCartProducts(List<CartItem> cartItems);
        Task<ResultDto<List<CartProductResponse>>> StoreCartItems(List<CartItem> cartItems);
        Task<ResultDto<int>> GetCartItemsCount();
        Task<ResultDto<List<CartProductResponse>>> GetDbCartProducts(int? userId = null);
        Task<ResultDto<bool>> AddToCart(CartItem cartItem);
        Task<ResultDto<bool>> UpdateQuantity(CartItem cartItem);
        Task<ResultDto<bool>> RemoveItemFromCart(int productId, int productTypeId);
    }
}
