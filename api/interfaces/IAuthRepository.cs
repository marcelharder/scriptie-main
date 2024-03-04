using System.Threading.Tasks;
using api.entities;

namespace api.Interfaces
{
    public interface IAuthRepository
    {
        Task<AppUser> Register(AppUser user, string password);
        Task<AppUser> Login(string username, string password);
        Task<bool> UserExists(string username);
        Task<AppUser> getUserByName(string username);
        Task<string> updatePassword(AppUser user, string password);
    }
}