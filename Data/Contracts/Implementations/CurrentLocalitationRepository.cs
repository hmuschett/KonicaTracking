﻿using KonicaTracking.Data.Context;

using Microsoft.EntityFrameworkCore;

namespace KonicaTracking.Data.Contracts.Implementations
{
    /// <summary>
    /// Implementation of the ICurrentLocalitationRepository interface for interacting with current location data in the database.
    /// </summary>
    public class CurrentLocalitationRepository : ICurrentLocalitationRepository
    {
        private ILogger _loggerManager;
        private AppDbContext _AppDbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentLocalitationRepository"/> class with the provided logger manager and database context.
        /// </summary>
        /// <param name="loggerManager">The logger manager used for logging.</param>
        /// <param name="AppDbContext">The database context for accessing current location data.</param>
        public CurrentLocalitationRepository(ILogger loggerManager, AppDbContext AppDbContext)
        {
            _loggerManager = loggerManager;
            _AppDbContext = AppDbContext;
        }

        /// <inheritdoc/>
        public async Task UpdateCurrentVehicleLocationAsync(int currentLocalitationId, decimal latitude, decimal longitude)
        {
            _loggerManager.LogTrace($"Starting the update of the current location with id {currentLocalitationId} with latitude {latitude} and longitude {longitude} .");

            var localitation = await _AppDbContext.CurrentLocations.AsQueryable().Where(x => x.Id.Equals(currentLocalitationId)).FirstOrDefaultAsync();
            localitation.Latitude = latitude;
            localitation.Longitude = longitude;
            await _AppDbContext.SaveChangesAsync();
        }
    }

}