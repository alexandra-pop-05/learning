using WebApi.Ex.Middlewares;

namespace WebApi.Ex.Extensions
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseResponseMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ResponseMiddleware>();
        }

        public static IApplicationBuilder UseLoggingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoggingMiddleware>();
        }

        public static IApplicationBuilder UseExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
