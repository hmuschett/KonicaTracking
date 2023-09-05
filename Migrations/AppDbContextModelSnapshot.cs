﻿// <auto-generated />
using System;
using KonicaTracking.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KonicaTracking.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2023, 9, 5, 16, 47, 39, 997, DateTimeKind.Local).AddTicks(5795),
                            Latitude = 40.4189m,
                            Longitude = -3.6919m
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2023, 9, 5, 16, 47, 39, 997, DateTimeKind.Local).AddTicks(5861),
                            Latitude = 40.4193m,
                            Longitude = -3.6905m
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2023, 9, 5, 16, 47, 39, 997, DateTimeKind.Local).AddTicks(5864),
                            Latitude = 40.4176m,
                            Longitude = -3.6890m
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2023, 9, 5, 16, 47, 39, 997, DateTimeKind.Local).AddTicks(5866),
                            Latitude = 40.4172m,
                            Longitude = -3.6883m
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2023, 9, 5, 16, 47, 39, 997, DateTimeKind.Local).AddTicks(5869),
                            Latitude = 40.4163m,
                            Longitude = -3.6871m
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2023, 9, 5, 16, 47, 39, 997, DateTimeKind.Local).AddTicks(5871),
                            Latitude = 40.4158m,
                            Longitude = -3.6862m
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateTime(2023, 9, 5, 16, 47, 39, 997, DateTimeKind.Local).AddTicks(5873),
                            Latitude = 40.4151m,
                            Longitude = -3.6854m
                        },
                        new
                        {
                            Id = 8,
                            Date = new DateTime(2023, 9, 5, 16, 47, 39, 997, DateTimeKind.Local).AddTicks(5876),
                            Latitude = 40.4146m,
                            Longitude = -3.6847m
                        },
                        new
                        {
                            Id = 9,
                            Date = new DateTime(2023, 9, 5, 16, 47, 39, 997, DateTimeKind.Local).AddTicks(5878),
                            Latitude = 40.4139m,
                            Longitude = -3.6838m
                        },
                        new
                        {
                            Id = 10,
                            Date = new DateTime(2023, 9, 5, 16, 47, 39, 997, DateTimeKind.Local).AddTicks(5881),
                            Latitude = 40.4133m,
                            Longitude = -3.6827m
                        });
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
                        .HasColumnType("int")
                        .HasColumnName("VehicleId")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CurrentLocationId")
                        .HasColumnType("int")
                        .HasColumnName("CurrentLocationId")
                        .HasColumnOrder(20);

                    b.Property<string>("Plate")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("Plate")
                        .HasColumnOrder(10);

                    b.HasKey("Id");

                    b.HasIndex("CurrentLocationId")
                        .IsUnique();

                    b.ToTable("Vehicles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CurrentLocationId = 1,
                            Plate = "AB123CD"
                        },
                        new
                        {
                            Id = 2,
                            CurrentLocationId = 2,
                            Plate = "XY456ZW"
                        },
                        new
                        {
                            Id = 3,
                            CurrentLocationId = 3,
                            Plate = "FG789HI"
                        },
                        new
                        {
                            Id = 4,
                            CurrentLocationId = 4,
                            Plate = "JK012LM"
                        },
                        new
                        {
                            Id = 5,
                            CurrentLocationId = 5,
                            Plate = "NO345PQ"
                        },
                        new
                        {
                            Id = 6,
                            CurrentLocationId = 6,
                            Plate = "RS678TU"
                        },
                        new
                        {
                            Id = 7,
                            CurrentLocationId = 7,
                            Plate = "VW901YZ"
                        },
                        new
                        {
                            Id = 8,
                            CurrentLocationId = 8,
                            Plate = "BC234EF"
                        },
                        new
                        {
                            Id = 9,
                            CurrentLocationId = 9,
                            Plate = "GH567IJ"
                        },
                        new
                        {
                            Id = 10,
                            CurrentLocationId = 10,
                            Plate = "KL890MN"
                        });
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
                        .WithOne()
                        .HasForeignKey("KonicaTracking.Data.Model.Vehicle", "CurrentLocationId")
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