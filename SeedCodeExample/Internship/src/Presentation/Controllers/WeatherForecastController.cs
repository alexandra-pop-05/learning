using Domain;
using Microsoft.AspNetCore.Mvc;
using Persistance;

namespace Internship.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly DataSeedingContext _context;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            DataSeedingContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            //using (var transaction = _context.Database.BeginTransaction())
            //{
            //    try
            //    {
            //        _context.Blogs.Add(new Blog { Url = "http://blogs.msdn.com/dotnet" });
            //        _context.SaveChanges();

            //        _context.Blogs.Add(new Blog { Url = "http://blogs.msdn.com/visualstudio" });
            //        _context.SaveChanges();

            //        transaction.Commit();
            //    }
            //    catch (Exception ex)
            //    {
            //        transaction.Rollback();
            //    }
            //}

            //using (var transaction = _context.Database.BeginTransaction())
            //{
            //    try
            //    {
            //        _context.Blogs.Add(new Blog { Url = "http://blogs.msdn.com/dotnet" });
            //        _context.SaveChanges();

            //        transaction.CreateSavepoint("s1");

            //        throw new Exception("test transaction");

            //        _context.Blogs.Add(new Blog { Url = "http://blogs.msdn.com/visualstudio" });
            //        _context.SaveChanges();

            //        transaction.Commit();
            //    }
            //    catch (Exception ex)
            //    {
            //        transaction.RollbackToSavepoint("s1");

            //        transaction.Commit();
            //    }
            //}

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}