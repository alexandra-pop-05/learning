namespace WebApi.Ex.Middlewares
{
    public class ResponseMiddleware
    {
        private readonly RequestDelegate _next;

        public ResponseMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context) //second part: InvokeAsync which receive HttpContext as param
        {
            //some logic
            await context.Response.WriteAsync("Helloooo!");
            
            //ne duce catre urmatorul middleware in pipeline
            //await _next(context);

            //se intoarce un response
            // other logic
        }
    }
}
