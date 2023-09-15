﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SecondDomain;

#nullable disable

namespace SecondDomain.Migrations
{
    [DbContext(typeof(TPT_EFCoreDbContext))]
    [Migration("20230811071720_MyFirstMigration")]
    partial class MyFirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SecondDomain.HEntities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("SecondDomain.HEntities.SystemRole", b =>
                {
                    b.HasBaseType("SecondDomain.HEntities.Role");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("SystemRoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("SystemRoles", (string)null);
                });

            modelBuilder.Entity("SecondDomain.HEntities.TeamRole", b =>
                {
                    b.HasBaseType("SecondDomain.HEntities.Role");

                    b.Property<bool>("IsBackend")
                        .HasColumnType("bit");

                    b.Property<string>("TeamRoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("TeamRoles");
                });

            modelBuilder.Entity("SecondDomain.HEntities.SystemRole", b =>
                {
                    b.HasOne("SecondDomain.HEntities.Role", null)
                        .WithOne()
                        .HasForeignKey("SecondDomain.HEntities.SystemRole", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SecondDomain.HEntities.TeamRole", b =>
                {
                    b.HasOne("SecondDomain.HEntities.Role", null)
                        .WithOne()
                        .HasForeignKey("SecondDomain.HEntities.TeamRole", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}