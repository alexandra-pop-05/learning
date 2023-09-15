using Microsoft.EntityFrameworkCore;
using EFCoreSeedAndMigrations.Models;

namespace EFCoreSeedAndMigrations
{
    public class EFSeedDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<MyEvent> Events { get; set; }


       /* public EFSeedDbContext(DbContextOptions<EFSeedDbContext> options) : base(options)
        {
        }*/

        public EFSeedDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
           => optionsBuilder.UseSqlServer(@"Server=DESKTOP-G6BRF6K;Database=EFDataSeeding;Trusted_Connection=True;TrustServerCertificate=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>(entity => { entity.Property(e => e.Name).IsRequired(); });

            modelBuilder.Entity<User>(entity => { entity.Property(e => e.FirstName).IsRequired(); });

            modelBuilder.Entity<MyEvent>(entity => { entity.Property(e => e.Name).IsRequired(); });

            modelBuilder.Entity<Project>().HasData(new Project { ProjectId = 1, Name = "Project1" });

            /*#region ProjectSeed
            modelBuilder.Entity<Project>().HasData(new Project { ProjectId = 2, Name = "Project1" });
            #endregion


            modelBuilder.Entity<User>(
                entity =>
                {
                    entity.HasOne(p => p.Project)
                          .WithMany(u => u.Users)
                          .HasForeignKey(u => u.ProjectId);
                });

            #region UserSeed
            modelBuilder.Entity<User>().HasData(new User
            {
                UserId = 1,
                FirstName = "Maria",
                LastName = "Pop",
                ProjectId = 1,
                MyEventId = 2
            },
            new User
            {
                UserId = 2,
                FirstName = "Alex",
                LastName = "Muresan",
                ProjectId = 2,
                MyEventId = 3
            });
            #endregion

            #region EventSeed
            modelBuilder.Entity<MyEvent>().HasData(
                new MyEvent
                {
                    MyEventId = 2,
                    Name = "Event2",
                    Date = new DateTime(2023, 10, 12)
                });

            modelBuilder.Entity<MyEvent>().HasData(
                new MyEvent
                {
                    MyEventId = 3,
                    Name = "Event3",
                    Date = new DateTime(2023, 12, 10)
                });

            modelBuilder.Entity<MyEvent>().HasData(
                new MyEvent
                {
                    MyEventId = 4,
                    Name = "Event4",
                    Date = new DateTime(2023, 12, 11)
                });
            modelBuilder.Entity<MyEvent>().HasData(
                new MyEvent
                {
                    MyEventId = 5,
                    Name = "Event4",
                    Date = new DateTime(2023, 12, 11)
                });
            #endregion
*/
            /*            #region OwnedTypeSeed
                        modelBuilder.Entity<User>().OwnsOne(p => p.EventName).HasData(
                            new { UserId = 1, EventId = 5, Name = "Event5", Date = new DateTime(2023, 10, 10) },
                            new { UserId = 2, EventId = 6, Name = "Event6", Date = new DateTime(2023, 12, 10) });
                        #endregion*/
        }
    }
}
