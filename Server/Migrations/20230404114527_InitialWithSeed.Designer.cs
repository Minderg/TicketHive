﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketHiveSpaceKittens.Server.Data;

#nullable disable

namespace TicketHiveSpaceKittens.Server.Migrations
{
    [DbContext(typeof(EventDbContext))]
    [Migration("20230404114527_InitialWithSeed")]
    partial class InitialWithSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EventModelEventTypesModel", b =>
                {
                    b.Property<string>("EventTypesTypeName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("EventsId")
                        .HasColumnType("int");

                    b.HasKey("EventTypesTypeName", "EventsId");

                    b.HasIndex("EventsId");

                    b.ToTable("EventModelEventTypesModel");

                    b.HasData(
                        new
                        {
                            EventTypesTypeName = "Utomhus",
                            EventsId = 1
                        });
                });

            modelBuilder.Entity("TicketHiveSpaceKittens.Shared.Models.BookingModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("Tickets")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("TicketHiveSpaceKittens.Shared.Models.EventModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TicketPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TicketsRemaining")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Fyllefest deluxe",
                            EventDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "",
                            Location = "Backyard",
                            Name = "Springbreak",
                            TicketPrice = 199m,
                            TicketsRemaining = 10
                        },
                        new
                        {
                            Id = 2,
                            Description = "Fyllefest deluxe2",
                            EventDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "",
                            Location = "Backyard2",
                            Name = "Springbreak2",
                            TicketPrice = 1992m,
                            TicketsRemaining = 102
                        });
                });

            modelBuilder.Entity("TicketHiveSpaceKittens.Shared.Models.EventTypesModel", b =>
                {
                    b.Property<string>("TypeName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TypeName");

                    b.ToTable("EventTypes");

                    b.HasData(
                        new
                        {
                            TypeName = "Utomhus"
                        });
                });

            modelBuilder.Entity("TicketHiveSpaceKittens.Shared.Models.EventTypesViewModel", b =>
                {
                    b.Property<string>("TypeName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("EventViewModelId")
                        .HasColumnType("int");

                    b.HasKey("TypeName");

                    b.HasIndex("EventViewModelId");

                    b.ToTable("EventTypesViewModel");
                });

            modelBuilder.Entity("TicketHiveSpaceKittens.Shared.Models.EventViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TicketPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TicketsRemaining")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EventViewModel");
                });

            modelBuilder.Entity("EventModelEventTypesModel", b =>
                {
                    b.HasOne("TicketHiveSpaceKittens.Shared.Models.EventTypesModel", null)
                        .WithMany()
                        .HasForeignKey("EventTypesTypeName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicketHiveSpaceKittens.Shared.Models.EventModel", null)
                        .WithMany()
                        .HasForeignKey("EventsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TicketHiveSpaceKittens.Shared.Models.BookingModel", b =>
                {
                    b.HasOne("TicketHiveSpaceKittens.Shared.Models.EventViewModel", "Event")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("TicketHiveSpaceKittens.Shared.Models.EventTypesViewModel", b =>
                {
                    b.HasOne("TicketHiveSpaceKittens.Shared.Models.EventViewModel", null)
                        .WithMany("EventTypes")
                        .HasForeignKey("EventViewModelId");
                });

            modelBuilder.Entity("TicketHiveSpaceKittens.Shared.Models.EventViewModel", b =>
                {
                    b.Navigation("EventTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
