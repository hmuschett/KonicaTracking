using KonicaTracking.Data.Context;
using KonicaTracking.Data.Models;
using KonicaTracking.Services.Models;
using Microsoft.EntityFrameworkCore;

namespace KonicaTracking.Data.Contracts.Implementations
{

    /// <summary>
    /// Implementation of the IUsersRepository interface for interacting with user data in the database.
    /// </summary>
    public class UsersRepository : IUsersRepository
    {
        private readonly ILogger<UsersRepository> _loggerManager;
        private readonly AppDbContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersRepository"/> class with the provided logger manager and database context.
        /// </summary>
        /// <param name="lggerManager">The logger manager used for logging.</param>
        /// <param name="context">The database context for accessing user data.</param>
        public UsersRepository(ILogger<UsersRepository> lggerManager, AppDbContext context)
        {
            _loggerManager = lggerManager;
            _context = context;
        }

        /// <summary>
        /// Attempts to log in a user by verifying the user's credentials asynchronously.
        /// </summary>
        /// <param name="user">The user object containing login credentials (username and password).</param>
        /// <returns>
        ///   <c>true</c> if the user with the provided credentials exists and can be logged in; otherwise, <c>false</c>.
        /// </returns>
        public async Task<bool> LoginUserAsync(IUser user)
        {
            _loggerManager.LogTrace($"Starting user exist check.");

            // Query the database to find a user with the provided username and password.
            var userResponse = await _context.Users
                .AsQueryable()
                .Where(x => x.Name.Equals(user.Name) && x.Password.Equals(user.Password))
                .FirstOrDefaultAsync();

            // Return true if a user with the provided credentials exists; otherwise, return false.
            return userResponse != null;
        }

        /// <summary>
        /// Registers a token for a user asynchronously.
        /// </summary>
        /// <param name="user">The user object containing the token to register.</param>
        /// <returns>
        ///   <c>true</c> if the user with the provided credentials exists and the token is registered successfully; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="NullReferenceException">Thrown if the user with the provided credentials is not found.</exception>
        public async Task RegisterTokenUserAsync(IUser user)
        {
            User userResponse = await _context.Users
                .AsQueryable()
                .Where(x => x.Name.Equals(user.Name) && x.Password.Equals(user.Password))
                .FirstOrDefaultAsync();

            if (userResponse == null) throw new NullReferenceException($"User {user.Name} not found.");
            userResponse.Token = user.Token;

            await _context.SaveChangesAsync();
        }
    }
}
