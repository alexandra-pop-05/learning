
using FluentValidation;
using InternshipExamples.ExceptionFilter;
using InternshipExamples.GetUserById;
using LoanPal.Directory.Application.Behaviors;
using MediatR;
using Serilog;
using System.Diagnostics;

namespace InternshipExamples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var isDebug = Debugger.IsAttached;

            var logConfiguration = new LoggerConfiguration()
              .MinimumLevel.Debug();
            //.WriteTo.Console();

#if DEBUG
            logConfiguration.WriteTo.Console();
            /*if (!isDebug)
            {*/
#else
            // If not running in Debug, configure "File" logging
            logConfiguration.WriteTo.File(Path.Combine(AppContext.BaseDirectory, "log.txt"));
           // }
#endif
            Log.Logger = logConfiguration.CreateLogger();
            /*Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                // Add more sinks if needed (e.g., WriteTo.File())
                .CreateLogger();*/


            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers(options => { options.Filters.Add(typeof(GlobalExceptionFilter)); });

            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

            builder.Services.AddValidatorsFromAssemblyContaining(typeof(GetUserByIdValidator));

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            var app = builder.Build();

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