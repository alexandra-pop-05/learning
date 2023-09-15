﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SeedAndMigrations;

#nullable disable

namespace SeedAndMigrations.Migrations
{
    [DbContext(typeof(EFSeedDbContext))]
    [Migration("20230818120943_NewPropertyProject")]
    partial class NewPropertyProject
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SeedAndMigrations.Models.MyEvent", b =>
                {
                    b.Property<int>("MyEventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MyEventId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MyEventId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            MyEventId = 2,
                            Date = new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Event2"
                        },
                        new
                        {
                            MyEventId = 3,
                            Date = new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Event3"
                        },
                        new
                        {
                            MyEventId = 4,
                            Date = new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Event4"
                        },
                        new
                        {
                            MyEventId = 5,
                            Date = new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Event4"
                        });
                });

            modelBuilder.Entity("SeedAndMigrations.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            ProjectId = 1,
                            Name = "Project1",
                            Version = 1
                        },
                        new
                        {
                            ProjectId = 2,
                            Name = "Project1",
                            Version = 0
                        });
                });

            modelBuilder.Entity("SeedAndMigrations.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MyEventId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("MyEventId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            FirstName = "Maria",
                            LastName = "Pop",
                            MyEventId = 2,
                            ProjectId = 1
                        },
                        new
                        {
                            UserId = 2,
                            FirstName = "Alex",
                            LastName = "Muresan",
                            MyEventId = 3,
                            ProjectId = 2
                        });
                });

            modelBuilder.Entity("SeedAndMigrations.Models.User", b =>
                {
                    b.HasOne("SeedAndMigrations.Models.MyEvent", "Event")
                        .WithMany()
                        .HasForeignKey("MyEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SeedAndMigrations.Models.Project", "Project")
                        .WithMany("Users")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("SeedAndMigrations.Models.Project", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
