using Bogus;
using Microsoft.EntityFrameworkCore;
using SeedAndMigrations.Models;

namespace SeedAndMigrations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*var dbContextOptions = new DbContextOptionsBuilder<EFSeedDbContext>()
                .UseSqlServer("your_connection_string_here")
                .Options;*/
/*
            using (var context = new EFSeedDbContext())

            {
                // Clear existing data (optional)
                *//*context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
*//*
                context.Database.Migrate();
                // Create a Faker instance for generating fake data
                var faker = new Faker();

                // Seed projects
                var projects = faker.Random.Number(3, 5);
                for (int i = 1; i <= projects; i++)
                {
                    context.Projects.Add(new Project { ProjectId = i, Name = $"Project{i}" });
                }

                // Seed users
                var users = faker.Random.Number(10, 20);
                for (int i = 1; i <= users; i++)
                {
                    context.Users.Add(new User
                    {
                        UserId = i,
                        FirstName = faker.Person.FirstName,
                        LastName = faker.Person.LastName,
                        ProjectId = faker.Random.Number(1, projects),
                        MyEventId = faker.Random.Number(2, 3)
                    });
                }

                // Seed events
                var events = faker.Random.Number(5, 10);
                for (int i = 4; i <= events + 3; i++)
                {
                    context.Events.Add(new MyEvent
                    {
                        MyEventId = i,
                        Name = $"Event{i}",
                        Date = faker.Date.Future()
                    });
                }

                context.SaveChanges();
            }*/
        }
    }
}
