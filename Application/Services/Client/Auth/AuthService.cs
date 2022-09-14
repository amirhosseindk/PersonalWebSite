using Application.Interfaces.Client.Auth;
using Common.ServiceResponse;
using Domain.Entities.User;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Json;

namespace Application.Services.Client.Auth
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _http;
        private readonly AuthenticationStateProvider _authStateProvider;

        public AuthService(HttpClient http, AuthenticationStateProvider authStateProvider)
        {
            _http = http;
            _authStateProvider = authStateProvider;
        }

        public async Task<ResultDto<bool>> ChangePassword(UserChangePassword request)
        {
            var result = await _http.PostAsJsonAsync("api/auth/change-password", request.Password);
            return await result.Content.ReadFromJsonAsync<ResultDto<bool>>();
        }

        public async Task<ResultDto<string>> Login(UserLogin request)
        {
            var result = await _http.PostAsJsonAsync("api/auth/login", request);
            return await result.Content.ReadFromJsonAsync<ResultDto<string>>();
        }

        public async Task<ResultDto<int>> Register(UserRegister request)
        {
            var result = await _http.PostAsJsonAsync("api/auth/register", request);
            return await result.Content.ReadFromJsonAsync<ResultDto<int>>();
        }

        public async Task<bool> IsUserAuthenticated()
        {
            return (await _authStateProvider.GetAuthenticationStateAsync()).User.Identity.IsAuthenticated;
        }


        //public async Task HandleLogin(UserLogin user,string errorMessage, ILocalStorageService LocalStorage,string returnUrl, AuthenticationStateProvider AuthenticationStateProvider, NavigationManager navigationManager)
        //{

        //    var result = await Login(user);
        //    if (result.IsSuccess)
        //    {
        //        errorMessage = string.Empty;

        //        await LocalStorage.SetItemAsync("authToken", result.Data);
        //        await AuthenticationStateProvider.GetAuthenticationStateAsync();
        //        navigationManager.NavigateTo(returnUrl);
        //    }
        //    else
        //    {
        //        errorMessage = result.Message;
        //    }
        //}
    }
}
