using Common.ServiceResponse;
using Domain.Entities.User;

namespace Application.Interfaces.Client.Auth
{
    public interface IAuthService
    {
        Task<ResultDto<int>> Register(UserRegister request);
        Task<ResultDto<string>> Login(UserLogin request);
        Task<ResultDto<bool>> ChangePassword(UserChangePassword request);
        Task<bool> IsUserAuthenticated();
        //Task HandleLogin(UserLogin user, string errorMessage, ILocalStorageService LocalStorage, string returnUrl, AuthenticationStateProvider AuthenticationStateProvider, NavigationManager navigationManager);
    }
}
