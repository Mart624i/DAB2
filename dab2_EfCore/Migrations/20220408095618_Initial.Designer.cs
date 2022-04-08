﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dab2_EfCore.Data;

#nullable disable

namespace dab2_EfCore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220408095618_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("dab2_EfCore.Models.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ClosingTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("LocationAddress")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("OpeningTime")
                        .HasColumnType("datetime2");

                    b.HasKey("BookingId");

                    b.HasIndex("LocationAddress");

                    b.ToTable("Bookings");

                    b.HasData(
                        new
                        {
                            BookingId = 1,
                            Address = "1",
                            ClosingTime = new DateTime(2022, 4, 8, 11, 56, 18, 236, DateTimeKind.Local).AddTicks(1429),
                            OpeningTime = new DateTime(2022, 4, 8, 11, 56, 18, 236, DateTimeKind.Local).AddTicks(1365)
                        },
                        new
                        {
                            BookingId = 2,
                            Address = "1",
                            ClosingTime = new DateTime(2022, 4, 8, 11, 56, 18, 236, DateTimeKind.Local).AddTicks(1448),
                            OpeningTime = new DateTime(2022, 4, 8, 11, 56, 18, 236, DateTimeKind.Local).AddTicks(1444)
                        });
                });

            modelBuilder.Entity("dab2_EfCore.Models.Chairman", b =>
                {
                    b.Property<int>("Member_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Member_id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cpr_number")
                        .HasColumnType("int");

                    b.Property<int>("Cvr_number")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Member_id");

                    b.HasIndex("Cvr_number")
                        .IsUnique();

                    b.ToTable("Chairmen");

                    b.HasData(
                        new
                        {
                            Member_id = 1,
                            Address = "Chairmanvejnummeret",
                            Cpr_number = 1111,
                            Cvr_number = 1,
                            Name = "Martin"
                        },
                        new
                        {
                            Member_id = 2,
                            Address = "Chairmanvejnummerto",
                            Cpr_number = 2222,
                            Cvr_number = 2,
                            Name = "Jens"
                        });
                });

            modelBuilder.Entity("dab2_EfCore.Models.Location", b =>
                {
                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessKey")
                        .HasColumnType("int");

                    b.Property<int>("Bathroom")
                        .HasColumnType("int");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<bool>("IsBooked")
                        .HasColumnType("bit");

                    b.Property<int?>("MunicipalityZipcode")
                        .HasColumnType("int");

                    b.Property<int>("Zipcode")
                        .HasColumnType("int");

                    b.HasKey("Address");

                    b.HasIndex("MunicipalityZipcode");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Address = "Denførstevej",
                            AccessKey = 0,
                            Bathroom = 1,
                            Capacity = 0,
                            IsBooked = false,
                            Zipcode = 8000
                        },
                        new
                        {
                            Address = "Denandenvej",
                            AccessKey = 0,
                            Bathroom = 2,
                            Capacity = 0,
                            IsBooked = false,
                            Zipcode = 7700
                        });
                });

            modelBuilder.Entity("dab2_EfCore.Models.Member", b =>
                {
                    b.Property<int>("Member_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Member_id"), 1L, 1);

                    b.Property<int>("Cvr_number")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SocietyCvr_number")
                        .HasColumnType("int");

                    b.HasKey("Member_id");

                    b.HasIndex("SocietyCvr_number");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            Member_id = 1,
                            Cvr_number = 1,
                            Name = "Jesper"
                        },
                        new
                        {
                            Member_id = 2,
                            Cvr_number = 2,
                            Name = "Carsten"
                        });
                });

            modelBuilder.Entity("dab2_EfCore.Models.Municipality", b =>
                {
                    b.Property<int>("Zipcode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Zipcode"), 1L, 1);

                    b.Property<int>("AccessKey")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Zipcode");

                    b.ToTable("Municipalities");

                    b.HasData(
                        new
                        {
                            Zipcode = 8000,
                            AccessKey = 1111,
                            Name = "Aarhus"
                        },
                        new
                        {
                            Zipcode = 7700,
                            AccessKey = 2222,
                            Name = "Thisted"
                        });
                });

            modelBuilder.Entity("dab2_EfCore.Models.Society", b =>
                {
                    b.Property<int>("Cvr_number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cvr_number"), 1L, 1);

                    b.Property<string>("Activity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<int?>("MunicipalityZipcode")
                        .HasColumnType("int");

                    b.Property<int>("Zipcode")
                        .HasColumnType("int");

                    b.HasKey("Cvr_number");

                    b.HasIndex("BookingId");

                    b.HasIndex("MunicipalityZipcode");

                    b.ToTable("Societies");

                    b.HasData(
                        new
                        {
                            Cvr_number = 1,
                            Activity = "Fodbold",
                            BookingId = 0,
                            Zipcode = 8000
                        },
                        new
                        {
                            Cvr_number = 2,
                            Activity = "Håndbold",
                            BookingId = 0,
                            Zipcode = 7700
                        });
                });

            modelBuilder.Entity("dab2_EfCore.Models.Booking", b =>
                {
                    b.HasOne("dab2_EfCore.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationAddress");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("dab2_EfCore.Models.Chairman", b =>
                {
                    b.HasOne("dab2_EfCore.Models.Society", "Society")
                        .WithOne("Chairman")
                        .HasForeignKey("dab2_EfCore.Models.Chairman", "Cvr_number")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Society");
                });

            modelBuilder.Entity("dab2_EfCore.Models.Location", b =>
                {
                    b.HasOne("dab2_EfCore.Models.Municipality", "Municipality")
                        .WithMany("Locations")
                        .HasForeignKey("MunicipalityZipcode");

                    b.Navigation("Municipality");
                });

            modelBuilder.Entity("dab2_EfCore.Models.Member", b =>
                {
                    b.HasOne("dab2_EfCore.Models.Society", "Society")
                        .WithMany("Members")
                        .HasForeignKey("SocietyCvr_number");

                    b.Navigation("Society");
                });

            modelBuilder.Entity("dab2_EfCore.Models.Society", b =>
                {
                    b.HasOne("dab2_EfCore.Models.Booking", "Booking")
                        .WithMany()
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dab2_EfCore.Models.Municipality", "Municipality")
                        .WithMany("ListOfSocieties")
                        .HasForeignKey("MunicipalityZipcode");

                    b.Navigation("Booking");

                    b.Navigation("Municipality");
                });

            modelBuilder.Entity("dab2_EfCore.Models.Municipality", b =>
                {
                    b.Navigation("ListOfSocieties");

                    b.Navigation("Locations");
                });

            modelBuilder.Entity("dab2_EfCore.Models.Society", b =>
                {
                    b.Navigation("Chairman");

                    b.Navigation("Members");
                });
#pragma warning restore 612, 618
        }
    }
}