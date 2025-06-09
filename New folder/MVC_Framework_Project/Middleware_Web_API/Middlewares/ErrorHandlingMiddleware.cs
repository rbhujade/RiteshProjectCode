using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace Middleware_Web_API.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {

            //return _next(httpContext);
            try
            {
                // Pass the request to the next middleware
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                // Handle exceptions globally
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            // Log the exception (use a logger in real-world apps)
            Console.WriteLine($"Error: {exception.Message}");

            // Set HTTP status code and response
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.Response.ContentType = "application/json";

            var errorResponse = new
            {
                context.Response.StatusCode,
                Message = "An unexpected error occurred. Please try again later.",
                Details = exception.Message // Avoid sending stack trace in production
            };

            return context.Response.WriteAsync(JsonSerializer.Serialize(errorResponse));
        }
    }



    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ErrorHandlingMiddlewareExtensions
    {
        public static IApplicationBuilder UseErrorHandlingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ErrorHandlingMiddleware>();
        }
    }
}
