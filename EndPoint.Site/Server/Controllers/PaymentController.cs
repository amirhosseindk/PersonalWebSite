using Application.Interfaces.Server.Payment;
using Microsoft.AspNetCore.Authorization;

namespace EndPoint.Site.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost("checkout"), Authorize]
        public async Task<ActionResult<string>> CreateCheckoutSession()
        {
            var session = await _paymentService.CreateCheckoutSession();
            return Ok(session.Url);
        }

        [HttpPost]
        public async Task<ActionResult<ResultDto<bool>>> FulfillOrder()
        {
            var response = await _paymentService.FulfillOrder(Request);
            if (!response.IsSuccess)
                return BadRequest(response.Message);

            return Ok(response);
        }
    }
}
