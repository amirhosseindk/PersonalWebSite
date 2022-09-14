using Common.ServiceResponse;
using Domain.Entities.User;

namespace Application.Interfaces.Server.Auth
{
    public interface IAuthService
    {
        Task<ResultDto<int>> Register(User user, string password);
        Task<bool> UserExists(string email);
        Task<ResultDto<string>> Login(string email, string password);
        Task<ResultDto<bool>> ChangePassword(int userId, string newPassword);
        int GetUserId();
        string GetUserEmail();
        Task<User> GetUserByEmail(string email);
    }
}
