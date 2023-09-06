﻿using KonicaTracking.Data.Contracts;
using KonicaTracking.Data.Contracts.Implementations;

namespace KonicaTracking.Data.Register
{
    /// <summary>
    /// Register data layer dependency injections
    /// </summary>
    public static class DataDI
    {
        /// <summary>
        /// Configure and register the necessary dependencies in the application's dependency injection container.
        /// </summary>
        /// <param name="services">The collection of services to which the dependencies will be added.</param>
        /// <returns>The same collection of services with dependencies added.</returns>
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            services.AddScoped<IVehiclesRepository, VehiclesRepository>();
            services.AddScoped<IOrdersRepository, OrdersRepository>();
            return services;
        }
    }
}
