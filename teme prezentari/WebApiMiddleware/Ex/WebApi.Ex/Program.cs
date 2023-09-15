using WebApi.Domain;
using WebApi.Ex.Extensions;
using WebApi.Ex.Middlewares;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IRepository, Repository>();
builder.Services.AddControllers().AddFluentValidation(s =>
{
    s.RegisterValidatorsFromAssemblyContaining<UserValidator>();
});

var app = builder.Build();




//app.Run(async context =>
//{
//    await context.Response.WriteAsync("Helloooo");
//}
//);

//app.UseMiddleware<ResponseMiddleware>();
//app.UseResponseMiddleware();
app.UseExceptionMiddleware();


//builder.Logging.ClearProviders();
//builder.Logging.AddDebug();

//app.UseLoggingMiddleware();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();


app.Run();

