using Microsoft.EntityFrameworkCore;
using SecondDomain.HEntities;

namespace SecondDomain;

public class TPT_EFCoreDbContext :DbContext
{
    public DbSet<Role> Roles { get; set; }
    public DbSet<SystemRole> SystemRoles { get; set; }
    public DbSet<TeamRole> TeamRoles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
=> optionsBuilder.UseSqlServer("Server=COSMINW\\SQLEXPRESS;Database=TPT_EFCoreCommonDB;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SystemRole>().ToTable("SystemRoles");
        modelBuilder.Entity<TeamRole>().UseTptMappingStrategy();
    }
}
