using Domain;
using Microsoft.EntityFrameworkCore;
using Persistance;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataSeedingContext>(options =>
    options
        .UseSqlServer(@"Server=DESKTOP-G6BRF6K;Database=EFDataSeeding;Trusted_Connection=True",
        sqlOptions => sqlOptions.MigrationsAssembly("Persistance")),
    ServiceLifetime.Transient);

var app = builder.Build();

#region CustomSeeding
using (var context = new DataSeedingContext())
{
    context.Database.EnsureCreated();

    var testBlog = context.Blogs.FirstOrDefault(b => b.Url == "http://test.com");
    if (testBlog == null)
    {
        context.Blogs.Add(new Blog { Url = "http://test.com" });
    }

    context.SaveChanges();
}
#endregion

using (var context = new DataSeedingContext())
{
    foreach (var blog in context.Blogs.Include(b => b.Posts))
    {
        Console.WriteLine($"Blog {blog.Url}");

        foreach (var post in blog.Posts)
        {
            Console.WriteLine($"\t{post.Title}: {post.Content} by {post.AuthorName.First} {post.AuthorName.Last}");
        }
    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
