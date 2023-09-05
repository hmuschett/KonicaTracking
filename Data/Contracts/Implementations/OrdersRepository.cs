using KonicaTracking.Data.Context;
using KonicaTracking.Data.Models;
using KonicaTracking.Services.Models;

namespace KonicaTracking.Data.Contracts.Implementations
{
    /// <summary>
    /// Implementation of the IOrdersRepository interface for creating orders in the database.
    /// </summary>
    public class OrdersRepository : IOrdersRepository
    {
        private readonly AppDbContext _context;
        

        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        /// <param name="logger">The logger for tracing.</param>
        public OrdersRepository(AppDbContext context)
        {
            _context = context;
        }

        /// <inheritdoc/>
        public async Task<bool> CreateOrderAsync(IOrder order)
        {
          

            Order orderEF = new Order(order);
            await _context.Orders.AddAsync(orderEF);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
