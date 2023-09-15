using Microsoft.EntityFrameworkCore;
using SecondDomain.HEntities;

namespace SecondDomain;

public class TPH_EFCoreDbContext : DbContext
{
    public DbSet<Role> Roles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
=> optionsBuilder.UseSqlServer("Server=COSMINW\\SQLEXPRESS;Database=TPH_EFCoreCommonDB;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Role>()
            .HasDiscriminator<string>("Type")
            .HasValue<SystemRole>("SystemRole")
            .HasValue<TeamRole>("TeamRole");
    }
}
