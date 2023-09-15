using InternshipExamples.GetUserById;
using InternshipExamples.UpdateUserById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace InternshipExamples.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<UserController> _logger;

        public UserController(IMediator mediator, ILogger<UserController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("{userId}")]
        public async Task<User?> GetUserById(int userId)
        {
            _logger.LogInformation("Getting user by ID: {UserId}", userId);
            var command = new GetUserByIdCommand
            {
                UserId = userId
            };

            var user = await _mediator.Send(command);

            return user;
        }

        [HttpPatch()]
        public async Task<User?> UpdateUserById(int userId, string Username)
        {
            _logger.LogInformation("Updating user by ID: {UserId}, Username: {Username}", userId, Username);

            var command = new UpdateUserByIdCommand
            {
                UserId = userId,
                Username= Username,
            };

            var updatedUser = await _mediator.Send(command);

            return updatedUser;
        }
    }
}
