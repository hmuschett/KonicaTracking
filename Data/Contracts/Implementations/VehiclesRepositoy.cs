using KonicaTracking.Data.Context;
using KonicaTracking.Services.Models;
using Microsoft.EntityFrameworkCore;

namespace KonicaTracking.Data.Contracts.Implementations
{
    /// <summary>
    /// Represents a repository for retrieving information about vehicles.
    /// </summary>
    public class VehiclesRepositoy : IVehiclesRepository
    {
        private readonly AppDbContext _context;

        /// <summary>
        /// Initialize a new instance of <see cref="VehiclesRepositoy"/> class.
        /// </summary>
        /// <param name="context">The database context for accessing vehicle data.</param>
        public VehiclesRepositoy(AppDbContext context)
        {
            _context = context;
        }

        /// <inheritdoc />
        public async Task<ICollection<IVehicle>> GetAllAsync()
        {
            var vehicles = _context.Vehicles.AsQueryable().Include(x => x.CurrentLocationObject);
            ICollection<IVehicle> ivehicles = await vehicles.Cast<IVehicle>().ToListAsync();
            return ivehicles;
        }
    }
}
