using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Middleware_Web_API.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class PostRequestMiddleware
    {
        private readonly RequestDelegate _next;

        public PostRequestMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            await _next(httpContext);

            if(httpContext.Response.StatusCode == StatusCodes.Status200OK)
            {
                httpContext.Response.Headers.Add("X-Custom-Header", "This is a post-request header");
            }

            //Console.WriteLine($"Response Status Code: {httpContext.Response.StatusCode}");
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class PostRequestMiddlewareExtensions
    {
        public static IApplicationBuilder UsePostRequestMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<PostRequestMiddleware>();
        }
    }
}
