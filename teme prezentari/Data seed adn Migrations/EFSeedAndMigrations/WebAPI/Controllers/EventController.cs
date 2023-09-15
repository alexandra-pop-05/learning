using Microsoft.AspNetCore.Mvc;
using SeedAndMigrations;
using SeedAndMigrations.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly EFSeedDbContext _context;

        public EventController(EFSeedDbContext context)
        {
            _context = context;
        }


        /*[HttpPost]
        public IActionResult Create(MyEvent eventData)
        {
            if (eventData == null)
            {
                return BadRequest("Invalid event data.");
            }

            using var transaction = _context.Database.BeginTransaction();

            try
            {
                // Add the first event
                _context.Events.Add(eventData);
                _context.SaveChanges();

                // Create a savepoint
                transaction.CreateSavepoint("savepoint1");

                // Add the second event
                _context.Events.Add(new MyEvent
                {
                    Name = "Another Event",
                    //Description = "This is another event.",
                    Date = DateTime.Now
                });
                _context.SaveChanges();

                // Commit the transaction
                transaction.Commit();

                return CreatedAtAction(nameof(GetEventById), new { id = eventData.MyEventId }, eventData);
            }
            catch (Exception ex)
            {
                // Rollback to the savepoint in case of an error
                transaction.RollbackToSavepoint("savepoint1");
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error: {ex.Message}");
            }
        }*/

        [HttpPost]
        public async Task<IActionResult> CreateEvent()
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    // Create a new event
                    var newEvent = new MyEvent
                    {
                        Name = "New Event",
                        Date = DateTime.Now
                    };
                    _context.Events.Add(newEvent);

                    await _context.SaveChangesAsync();
                    // Create a savepoint
                    transaction.CreateSavepoint("savepoint1");

                    //other operation
                    var newEvent2 = new MyEvent
                    {
                        MyEventId = 1,
                        Name = "Ale",
                        Date = DateTime.Now
                    };
                    _context.Events.Add(newEvent);

                    // Commit the changes to the database
                    await _context.SaveChangesAsync();

                    // Commit the transaction
                    transaction.Commit();

                    return Ok("Events added successfully.");
                }
                catch (Exception ex)
                {
                    // If an exception occurs, rollback the transaction
                    transaction.Rollback();
                    return BadRequest("An error occurred: " + ex.Message);
                }
            }
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetEventById(int id)
        {
            var eventData = await _context.Events.FindAsync(id);

            if (eventData == null)
            {
                return NotFound($"Event with ID {id} not found.");
            }

            return Ok(eventData);
        }
    }
}
