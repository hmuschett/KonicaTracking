using KonicaTracking.Data.Context;

using KonicaTracking.Services.Models;

namespace KonicaTracking.Data.Contracts.Implementations
{
    /// <summary>
    /// Implementation of the ILocalitationHistoryRepository interface for interacting with location history data in the database.
    /// </summary>
    public class LocalitationHistoryRepository : ILocalitationHistoryRepository
    {
        private ILogger _loggerManager;
        private AppDbContext _AppDbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalitationHistoryRepository"/> class with the provided logger manager and database context.
        /// </summary>
        /// <param name="loggerManager">The logger manager used for logging.</param>
        /// <param name="AppDbContext">The database context for accessing current location data.</param>
        public LocalitationHistoryRepository(ILogger loggerManager, AppDbContext AppDbContext)
        {
            _loggerManager = loggerManager;
            _AppDbContext = AppDbContext;
        }
    }
}
