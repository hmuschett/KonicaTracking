using KonicaTracking.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace KonicaTracking.Data.Context
{
    /// <summary>
    /// Class to manage data context.
    /// </summary>
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// Inicitalize a new instance of <see cref="AppDbContext"/> class.
        /// </summary>
        /// <param name="options"></param>
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        /// <summary>
        /// Called when the database model is created.
        /// Allows you to configure the relationships and constraints of the database.
        /// </summary>
        /// <param name="modelBuilder">The model builder used to configure the database model.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Location.Configure(modelBuilder);
            LocationHistory.Configure_LocationHistory(modelBuilder);
            Order.Configure(modelBuilder);
        }
    }
}
