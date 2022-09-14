using Application.Interfaces.Server.Address;
using Microsoft.AspNetCore.Authorization;

namespace EndPoint.Site.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet]
        public async Task<ActionResult<ResultDto<Address>>> GetAddress()
        {
            return await _addressService.GetAddress();
        }

        [HttpPost]
        public async Task<ActionResult<ResultDto<Address>>> AddOrUpdateAddress(Address address)
        {
            return await _addressService.AddOrUpdateAddress(address);
        }
    }
}
