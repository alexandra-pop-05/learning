using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using WebApi.Domain;
using WebApi.Ex.Exceptions;

namespace WebApi.Ex.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private IRepository _repository;
        public UsersController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult GetUsers()
        {
            var allUsers = _repository.GetUsers();

            return Ok(allUsers);
        }

        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        [HttpGet("{id}")]
        public ActionResult UserById(int id)
        {
            try
            {
                var userById = _repository.GetUserById(id);

                return Ok(userById);
            }
            catch (Exception ex)
            {
                /*throw new CustomException1();
                //throw new Exception();*/
                throw new CustomException(new Details { StatusCode = 500, Message = "Errorrrrrr" });

            }
            /* catch (Exception ex)
             {
                 throw new UserNotFoundException();
             }*/

        }

        [HttpPost]
        public ActionResult AddUser(User user)
        {
            try
            {
                _repository.AddUser(user);

                return CreatedAtAction(nameof(UserById), new { id = user.Id }, user);
                return Ok();
            }
            /* catch (AccessViolationException ex)
             {
                 throw new CustomException1();
                 //throw new Exception();
             }
             catch (Exception ex)
             {
                 throw new UserNotFoundException();
             }*/
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            try
            {
                _repository.DeleteUserById(id);

                return Ok();
            }
            catch (ArgumentException ex)
            {
                return NotFound();
            }
            catch (AccessViolationException ex)
            {
                return Problem(statusCode: 500);
            }
        }
    }
}
