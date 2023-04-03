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
    [Migration("20230403125557_EventDb-Initial")]
    partial class EventDbInitial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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
                });

            modelBuilder.Entity("TicketHiveSpaceKittens.Shared.Models.EventTypesModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("EventModelId")
                        .HasColumnType("int");

                    b.Property<string>("EventTypes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EventViewModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventModelId");

                    b.HasIndex("EventViewModelId");

                    b.ToTable("EventTypesModel");
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

                    b.Property<int?>("UserModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserModelId");

                    b.ToTable("EventViewModel");
                });

            modelBuilder.Entity("TicketHiveSpaceKittens.Shared.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Country")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EventModelId")
                        .HasColumnType("int");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EventModelId");

                    b.ToTable("UserModel");
                });

            modelBuilder.Entity("TicketHiveSpaceKittens.Shared.Models.EventTypesModel", b =>
                {
                    b.HasOne("TicketHiveSpaceKittens.Shared.Models.EventModel", null)
                        .WithMany("EventTypes")
                        .HasForeignKey("EventModelId");

                    b.HasOne("TicketHiveSpaceKittens.Shared.Models.EventViewModel", null)
                        .WithMany("EventTypes")
                        .HasForeignKey("EventViewModelId");
                });

            modelBuilder.Entity("TicketHiveSpaceKittens.Shared.Models.EventViewModel", b =>
                {
                    b.HasOne("TicketHiveSpaceKittens.Shared.Models.UserModel", null)
                        .WithMany("BookedEvents")
                        .HasForeignKey("UserModelId");
                });

            modelBuilder.Entity("TicketHiveSpaceKittens.Shared.Models.UserModel", b =>
                {
                    b.HasOne("TicketHiveSpaceKittens.Shared.Models.EventModel", null)
                        .WithMany("Users")
                        .HasForeignKey("EventModelId");
                });

            modelBuilder.Entity("TicketHiveSpaceKittens.Shared.Models.EventModel", b =>
                {
                    b.Navigation("EventTypes");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("TicketHiveSpaceKittens.Shared.Models.EventViewModel", b =>
                {
                    b.Navigation("EventTypes");
                });

            modelBuilder.Entity("TicketHiveSpaceKittens.Shared.Models.UserModel", b =>
                {
                    b.Navigation("BookedEvents");
                });
#pragma warning restore 612, 618
        }
    }
}
