using Microsoft.EntityFrameworkCore;
using SeedAndMigrations;
using SeedAndMigrations.Models;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<EFSeedDbContext>(options =>
    options
        .UseSqlServer(@"Server=DESKTOP-G6BRF6K;Database=EFDataSeeding;Trusted_Connection=True;TrustServerCertificate=True",
        sqlOptions => sqlOptions.MigrationsAssembly("SeedAndMigrations")),
    ServiceLifetime.Transient);

            var app = builder.Build();


            //without migrations
            #region CustomSeeding
            using (var context = new EFSeedDbContext())
            {
                context.Database.EnsureCreated();

                var testProject = context.Projects.FirstOrDefault(b => b.Name == "Project1");
                if (testProject == null)
                {
                    context.Projects.Add(new Project { Name = "Project1" });
                }

                context.SaveChanges();
            }
            #endregion


            using (var context = new EFSeedDbContext())
            {
                foreach (var project in context.Projects.Include(b => b.Users))
                {
                    Console.WriteLine($"Project {project.Name}");

                    foreach (var user in project.Users)
                    {
                        var eventName = user.Event?.Name ?? "No Event";
                        Console.WriteLine($"\t{user.FirstName}: {project.Name}, {eventName}");
                    }
                }
            }
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}