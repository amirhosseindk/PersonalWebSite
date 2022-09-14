using Application.Interfaces.Client.Address;
using Common.ServiceResponse;
using System.Net.Http.Json;

namespace Application.Services.Client.Address
{
    public class AddressService : IAddressService
    {
        private readonly HttpClient _http;
        public AddressService(HttpClient http)
        {
            _http = http;
        }
        public async Task<Domain.Entities.User.Address> AddOrUpdateAddress(Domain.Entities.User.Address address)
        {
            var response = await _http.PostAsJsonAsync("api/address", address);
            return response.Content
                .ReadFromJsonAsync<ResultDto<Domain.Entities.User.Address>>().Result.Data;
        }

        public async Task<Domain.Entities.User.Address> GetAddress()
        {
            var response = await _http
                .GetFromJsonAsync<ResultDto<Domain.Entities.User.Address>>("api/address");
            return response.Data;
        }
    }
}
