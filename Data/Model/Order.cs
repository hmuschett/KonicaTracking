﻿using Microsoft.EntityFrameworkCore;

namespace KonicaTracking.Data.Model
{
    /// <summary>
    /// Represents an order with an identifier, description, assigned vehicle, and status.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets or sets the unique identifier of the order.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the description of the order.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the id vehicle.
        /// </summary>
        public int? AssignedVehicleId { get; set; }

        /// <summary>
        /// Gets or sets the vehicle assigned to fulfill the order.
        /// </summary>
        public virtual Vehicle? AssignedVehicle { get; set; }

        /// <summary>
        /// Gets or sets the status of the order.
        /// </summary>
        public OrderStatus Status { get; set; }

        /// <summary>
        /// Configures the entity mapping for the 'Order' model, specifying the table name as 'Orders'.
        /// </summary>
        /// <param name="modelBuilder">The ModelBuilder instance used to configure the entity mapping.</param>
        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().ToTable("Orders");
            modelBuilder.Entity<Order>().HasKey(o => o.Id);

            modelBuilder.Entity<Order>()
                .Property(o => o.Id)
                .HasColumnName("OrderId")
                .HasColumnOrder(0)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Order>()
                .Property(l => l.Description)
                .HasColumnType("nvarchar(255)")
                .HasColumnName(nameof(Description))
                .HasColumnOrder(10)
                .IsRequired();

            modelBuilder.Entity<Order>()
                .Property(l => l.AssignedVehicleId)
                .HasColumnType("int")
                .HasColumnName(nameof(AssignedVehicleId))
                .HasColumnOrder(20);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.AssignedVehicle)
                .WithMany(v => v.Orders)
                .HasForeignKey(o => o.AssignedVehicleId);

            modelBuilder.Entity<Order>()
                .Property(l => l.Status)
                .HasColumnType("int")
                .HasColumnName(nameof(Status))
                .HasColumnOrder(30)
                .IsRequired();
        }
    }
   
    /// <summary>
    /// Represents the possible status values of an order.
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// The order has been placed but not yet in transit.
        /// </summary>
        Placed,

        /// <summary>
        /// The order is in transit.
        /// </summary>
        InTransit,

        /// <summary>
        /// The order has been delivered.
        /// </summary>
        Delivered,

        /// <summary>
        /// The order has been canceled.
        /// </summary>
        Canceled
    }

}
