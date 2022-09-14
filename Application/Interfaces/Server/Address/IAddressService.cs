using Common.ServiceResponse;

namespace Application.Interfaces.Server.Address
{
    public interface IAddressService
    {
        Task<ResultDto<Domain.Entities.User.Address>> GetAddress();
        Task<ResultDto<Domain.Entities.User.Address>> AddOrUpdateAddress(Domain.Entities.User.Address address);
    }
}
