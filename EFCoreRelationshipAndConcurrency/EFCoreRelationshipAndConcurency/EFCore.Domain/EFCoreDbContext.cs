using EFCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Domain;

public  class EFCoreDbContext : DbContext
{
    public DbSet<Person> Persons { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<UserProject> UserProjects { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     =>   optionsBuilder.UseSqlServer("Server=DESKTOP-G6BRF6K;Database=EFCoreCommonDB;Trusted_Connection=true;Encrypt=false;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .HasKey(p => p.Id);

        modelBuilder.Entity<Person>()
            .HasOne(p => p.User)
            .WithOne(u => u.Person)
            .OnDelete(DeleteBehavior.SetNull)
            .HasForeignKey<User>(u => u.Id);

        modelBuilder.Entity<Review>()
            .HasOne(r => r.User)
            .WithMany(u => u.Reviews)
            .HasForeignKey(r => r.AddedBy);

        modelBuilder.Entity<UserProject>()
            .HasKey(up => up.UserProjectId);

        modelBuilder.Entity<UserProject>()
            .HasOne(up => up.User)
            .WithMany(u => u.Projects)
            .HasForeignKey(up => up.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<UserProject>()
            .HasOne(up => up.Project)
            .WithMany(p => p.Users)
            .HasForeignKey(up => up.ProjectId);

        modelBuilder.Entity<Project>()
            .Property(p => p.RowVersion)
            .IsRowVersion();
    }
}
