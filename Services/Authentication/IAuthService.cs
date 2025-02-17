using System.Threading.Tasks;

namespace BlazorSportStoreAuth.Services.Authentication
{
    public interface IAuthService
    {
        Task<bool> LoginAsync(string email, string password);
        Task<bool> RegisterAsync(string email, string password);
        Task LogoutAsync();
    }
}
