﻿using Microsoft.EntityFrameworkCore;
namespace KonicaTracking.Data.Model
{
    public class LocationHistory : Location
    {
        /// <summary>
        /// Configures the entity mapping for the 'Order' model, specifying the table name as 'Orders'.
        /// </summary>
        /// <param name="modelBuilder">The ModelBuilder instance used to configure the entity mapping.</param>
        public static void Configure_LocationHistory(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LocationHistory>().ToTable("LocationsHistory");
            modelBuilder.Entity<LocationHistory>().HasKey(e => e.Id);

            modelBuilder.Entity<LocationHistory>()
                .Property(l => l.Id)
                .HasColumnName("LocationHistoryId")
                .HasColumnOrder(0)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<LocationHistory>()
                .Property(l => l.Date)
                .HasColumnType("datetime")
                .HasColumnName(nameof(Date))
                .HasColumnOrder(10)
                .IsRequired();

            modelBuilder.Entity<LocationHistory>()
                .Property(l => l.Latitude)
                .HasColumnType("decimal(10, 7)")
                .HasPrecision(10, 7)
                .HasColumnName(nameof(Latitude))
                .HasColumnOrder(20)
                .IsRequired();

            modelBuilder.Entity<LocationHistory>()
                .Property(l => l.Longitude)
                .HasColumnType("decimal(10, 7)")
                .HasPrecision(10, 7)
                .HasColumnName(nameof(Longitude))
                .HasColumnOrder(30)
                .IsRequired();
        }
    }
}