﻿using System.Text.Json.Serialization;
using KonicaTracking.Data.Models;
using KonicaTracking.Services.Models;

namespace KonicaTracking.Models.Request
{
    /// <summary>
    /// Represents an order request that implements the <see cref="IOrder"/> interface.
    /// </summary>
    public class OrderRequest : IOrder
    {
        /// <inheritdoc />
        public int Id { get; set; }

        /// <inheritdoc />
        public string Description { get; set; }
        /// <inheritdoc />
        public int? AssignedVehicleId { get; set; }
        /// <inheritdoc />
        [JsonIgnore]
        public IVehicle AssignedVehicle { get; set; }
        /// <inheritdoc />
        public OrderStatus Status { get; set; }
    }


}
