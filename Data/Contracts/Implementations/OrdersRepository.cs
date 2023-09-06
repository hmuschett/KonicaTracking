﻿using KonicaTracking.Data.Context;
using KonicaTracking.Data.Models;
using KonicaTracking.Services.Models;
using Microsoft.EntityFrameworkCore;


namespace KonicaTracking.Data.Contracts.Implementations
{
    /// <summary>
    /// Implementation of the IOrdersRepository interface for creating orders in the database.
    /// </summary>
    public class OrdersRepository : IOrdersRepository
    {
        private readonly AppDbContext _context;
        private readonly ILogger<OrdersRepository> _logger;
        

        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        /// <param name="logger">The logger for tracing.</param>
        public OrdersRepository(AppDbContext context, ILogger<OrdersRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <inheritdoc />
        public async Task<bool> CreateOrderAsync(IOrder order)
        {
            _logger.LogTrace($"Attempting to save {order}");
            Order orderEF = new Order(order);
            await _context.Orders.AddAsync(orderEF);
            await _context.SaveChangesAsync();
            return true;
        }

        /// <inheritdoc />
        public async Task<bool> DeleteOrderAsync(int orderId)
        {
            _logger.LogTrace($"Attempting to delete {orderId}");
            var order = await _context.Orders.FindAsync(orderId);
            if (order == null)
            {
                _logger.LogTrace($"Order dest'nt exits {orderId}");
                return false;
            }

            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
             _logger.LogTrace($"Delete was successful {orderId}");
            return true;
        }
        /// <inheritdoc />
        public async Task<bool> AssignVehicleToOrderAsync(int orderId, int vehicleId)
        {
            _logger.LogTrace($"Attempting to Assign a vehicle to order:  {orderId}");
            var order = await _context.Orders.FindAsync(orderId);
            if (order == null) return false;

            order.AssignedVehicleId = vehicleId;
            return await _context.SaveChangesAsync() > 0;
        }

        /// <inheritdoc />
        public async Task<ILocation> GetVehicleLocationAsync(int orderId)
        {
            _logger.LogTrace($"Attempting to Assign a vehicle to order {orderId}");
            var order = await _context.Orders
                                      .Include(o => o.AssignedVehicleObject)                                      
                                      .FirstOrDefaultAsync(o => o.Id == orderId);

            if (order?.AssignedVehicle == null)
            {
                return null;
            }

            return order.AssignedVehicleObject.CurrentLocation;
        }
    }
}
