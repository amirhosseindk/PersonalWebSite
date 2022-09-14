using Common.ServiceResponse;
using Microsoft.AspNetCore.Http;
using Stripe.Checkout;

namespace Application.Interfaces.Server.Payment
{
    public interface IPaymentService
    {
        Task<Session> CreateCheckoutSession();
        Task<ResultDto<bool>> FulfillOrder(HttpRequest request);
    }
}
