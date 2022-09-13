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
    }
}
