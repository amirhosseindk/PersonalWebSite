namespace Application.Interfaces.Client.Address
{
    public interface IAddressService
    {
        Task<Domain.Entities.User.Address> GetAddress();
        Task<Domain.Entities.User.Address> AddOrUpdateAddress(Domain.Entities.User.Address address);
    }
}
