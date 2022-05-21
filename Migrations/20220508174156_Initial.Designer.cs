﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkingMatic.Data;

#nullable disable

namespace ParkingMatic.Migrations
{
    [DbContext(typeof(ParkingMaticContext))]
    [Migration("20220508174156_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ParkingMatic.Models.ParkingSpot", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<bool>("Occupied")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("ParkingSpot");
                });

            modelBuilder.Entity("ParkingMatic.Models.Pass", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<bool>("Premium")
                        .HasColumnType("bit");

                    b.Property<string>("Purchaser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Pass");
                });

            modelBuilder.Entity("ParkingMatic.Models.Reservation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("Expiry")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCurrent")
                        .HasColumnType("bit");

                    b.Property<int>("ParkingSpotID")
                        .HasColumnType("int");

                    b.Property<int>("VehicleID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ParkingSpotID");

                    b.HasIndex("VehicleID");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("ParkingMatic.Models.Vehicle", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<bool>("Parked")
                        .HasColumnType("bit");

                    b.Property<int>("PassID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PassID");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("ParkingMatic.Models.Reservation", b =>
                {
                    b.HasOne("ParkingMatic.Models.ParkingSpot", "ParkingSpot")
                        .WithMany("Reservations")
                        .HasForeignKey("ParkingSpotID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ParkingMatic.Models.Vehicle", "Vehicle")
                        .WithMany("Reservations")
                        .HasForeignKey("VehicleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ParkingSpot");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("ParkingMatic.Models.Vehicle", b =>
                {
                    b.HasOne("ParkingMatic.Models.Pass", "Pass")
                        .WithMany("Vehicles")
                        .HasForeignKey("PassID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pass");
                });

            modelBuilder.Entity("ParkingMatic.Models.ParkingSpot", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("ParkingMatic.Models.Pass", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("ParkingMatic.Models.Vehicle", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
