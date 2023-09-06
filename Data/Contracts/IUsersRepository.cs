using KonicaTracking.Services.Models;

namespace KonicaTracking.Data.Contracts
{
    public interface IUsersRepository
    {
        Task<bool> LoginUserAsync(IUser user);
        Task RegisterTokenUserAsync(IUser user);
    }
}
