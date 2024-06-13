using Restaurant_api.Models;

namespace Restaurant_api.Data
{
    public interface IAuthRepository
    {

        Task<ServiceResponse<int>> Register(User user,string password,string confirmPassword);

        Task<ServiceResponse<string>> Login(string username, string password);

        Task<bool> UserExsits(string username);
    }
}
