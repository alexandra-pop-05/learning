using System.Net;
using WebApi.Ex.Exceptions;

namespace WebApi.Ex.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }


        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (CustomException ex)
            {
                /*await HandleUserNotFoundExceptionAsync(context, ex);*/
                //_logger.LogError(ex, "User not found exception.");

                context.Response.ContentType = "application/json";
                context.Response.StatusCode = ex.Details.StatusCode;

                var errorJson = ex.Details.ToString();
                await context.Response.WriteAsync(errorJson);
            }
            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync("Error");
            }
            /*catch (CustomException1 ex)
            {
                await HandleCustomException1Async(context, ex);
            }
            catch (Exception ex)
            {
                await HandleGeneralExceptionAsync(context, ex);
            }*/
        }

        /*private async Task HandleUserNotFoundExceptionAsync(HttpContext context, UserNotFoundException ex)
        {
            _logger.LogError(ex, "User not found exception.");

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.NotFound;

            await context.Response.WriteAsync("User not found.");
        }

        private async Task HandleCustomException1Async(HttpContext context, CustomException1 ex)
        {
            _logger.LogError(ex, "Custom bad request occurred.");

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.BadRequest;

            await context.Response.WriteAsync("Bad request.");
        }

        private async Task HandleGeneralExceptionAsync(HttpContext context, Exception ex)
        {
            _logger.LogError(ex, "An unhandled exception occurred.");

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            await context.Response.WriteAsync("An error occurred on the server. Please try again later.");
        }

    }

    public class CustomException1 : AccessViolationException
    {
        public CustomException1()
        {
        }

        public CustomException1(string message) : base(message)
        {
        }


    }


    public class UserNotFoundException : ArgumentException
    {
        public UserNotFoundException() : base()
        {

        }

        public UserNotFoundException(string message) : base(message)
        {

        }

    }*/
    }
}