

namespace Middleware_Custom.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ExceptionHandler
    {
        private readonly RequestDelegate _next;
        private readonly Logger<ExceptionHandler> _logger;

        public ExceptionHandler(RequestDelegate next, Logger<ExceptionHandler> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                _logger.LogError("Unhandle Error.");
                await HandleExceptionAsync(ex,httpContext);
            }
            
        }

        public static Task HandleExceptionAsync(Exception ex,HttpContext context)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;

            var result = new
            {
                status = context.Response.StatusCode,
                message = "An unexpected error occurred.",
                details = ex.Message
            };

            return context.Response.WriteAsJsonAsync(result);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ExceptionHandlerExtensions
    {
        public static IApplicationBuilder UseExceptionHandler(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionHandler>();
        }
    }
}
