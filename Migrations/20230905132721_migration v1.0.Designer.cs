﻿// <auto-generated />
using System;
using KonicaTracking.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KonicaTracking.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230905132721_migration v1.0")]
    partial class migrationv10
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KonicaTracking.Data.Model.CurrentLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CurrentLocationId")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime")
                        .HasColumnName("Date")
                        .HasColumnOrder(10);

                    b.Property<decimal>("Latitude")
                        .HasPrecision(10, 7)
                        .HasColumnType("decimal(10, 7)")
                        .HasColumnName("Latitude")
                        .HasColumnOrder(20);

                    b.Property<decimal>("Longitude")
                        .HasPrecision(10, 7)
                        .HasColumnType("decimal(10, 7)")
                        .HasColumnName("Longitude")
                        .HasColumnOrder(30);

                    b.HasKey("Id");

                    b.ToTable("CurrentLocations", (string)null);
                });

            modelBuilder.Entity("KonicaTracking.Data.Model.LocationHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("LocationHistoryId")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime")
                        .HasColumnName("Date")
                        .HasColumnOrder(10);

                    b.Property<decimal>("Latitude")
                        .HasPrecision(10, 7)
                        .HasColumnType("decimal(10, 7)")
                        .HasColumnName("Latitude")
                        .HasColumnOrder(20);

                    b.Property<decimal>("Longitude")
                        .HasPrecision(10, 7)
                        .HasColumnType("decimal(10, 7)")
                        .HasColumnName("Longitude")
                        .HasColumnOrder(30);

                    b.Property<int?>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId");

                    b.ToTable("LocationsHistory", (string)null);
                });

            modelBuilder.Entity("KonicaTracking.Data.Model.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OrderId")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AssignedVehicleId")
                        .HasColumnType("int")
                        .HasColumnName("AssignedVehicleId")
                        .HasColumnOrder(20);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Description")
                        .HasColumnOrder(10);

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("Status")
                        .HasColumnOrder(30);

                    b.HasKey("Id");

                    b.HasIndex("AssignedVehicleId");

                    b.ToTable("Orders", (string)null);
                });

            modelBuilder.Entity("KonicaTracking.Data.Model.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CurrentLocationId")
                        .HasColumnType("int");

                    b.Property<string>("Plate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CurrentLocationId");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("KonicaTracking.Data.Model.LocationHistory", b =>
                {
                    b.HasOne("KonicaTracking.Data.Model.Vehicle", null)
                        .WithMany("LocationHistory")
                        .HasForeignKey("VehicleId");
                });

            modelBuilder.Entity("KonicaTracking.Data.Model.Order", b =>
                {
                    b.HasOne("KonicaTracking.Data.Model.Vehicle", "AssignedVehicle")
                        .WithMany("Orders")
                        .HasForeignKey("AssignedVehicleId");

                    b.Navigation("AssignedVehicle");
                });

            modelBuilder.Entity("KonicaTracking.Data.Model.Vehicle", b =>
                {
                    b.HasOne("KonicaTracking.Data.Model.CurrentLocation", "CurrentLocation")
                        .WithMany()
                        .HasForeignKey("CurrentLocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CurrentLocation");
                });

            modelBuilder.Entity("KonicaTracking.Data.Model.Vehicle", b =>
                {
                    b.Navigation("LocationHistory");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}