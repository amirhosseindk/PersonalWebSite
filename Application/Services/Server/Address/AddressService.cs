using Application.Interfaces.Server.Address;
using Application.Interfaces.Server.Auth;
using Common.ServiceResponse;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Application.Services.Server.Address
{
    public class AddressService : IAddressService
    {
        private readonly DataBaseContext _context;
        private readonly IAuthService _authService;

        public AddressService(DataBaseContext context, IAuthService authService)
        {
            _context = context;
            _authService = authService;
        }

        public async Task<ResultDto<Domain.Entities.User.Address>> AddOrUpdateAddress(Domain.Entities.User.Address address)
        {
            var response = new ResultDto<Domain.Entities.User.Address>();
            var dbAddress = (await GetAddress()).Data;
            if (dbAddress == null)
            {
                address.UserId = _authService.GetUserId();
                _context.Addresses.Add(address);
                response.Data = address;
            }
            else
            {
                dbAddress.FirstName = address.FirstName;
                dbAddress.LastName = address.LastName;
                dbAddress.State = address.State;
                dbAddress.Country = address.Country;
                dbAddress.City = address.City;
                dbAddress.Zip = address.Zip;
                dbAddress.Street = address.Street;
                response.Data = dbAddress;
            }

            await _context.SaveChangesAsync();

            return response;
        }

        public async Task<ResultDto<Domain.Entities.User.Address>> GetAddress()
        {
            int userId = _authService.GetUserId();
            var address = await _context.Addresses
                .FirstOrDefaultAsync(a => a.UserId == userId);
            return new ResultDto<Domain.Entities.User.Address> { Data = address , IsSuccess = true , Message = "success"};
        }
    }
}
