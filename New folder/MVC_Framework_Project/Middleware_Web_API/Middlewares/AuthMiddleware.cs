using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Text;
using System.Threading.Tasks;

namespace Middleware_Web_API.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class AuthMiddleware
    {
        private readonly RequestDelegate next;
        private readonly string relm;

        public AuthMiddleware(RequestDelegate next, string relm)
        {
            this.next = next;
            this.relm = relm;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            if (!httpContext.Request.Headers.ContainsKey("Authorization"))
            {
                httpContext.Response.StatusCode = 401;
                await httpContext.Response.WriteAsync("Unauthorized");
                return;
            }

            var headers = httpContext.Request.Headers["Authorization"].ToString();
            var encode = headers.Substring(6);
            var cred = Encoding.UTF8.GetString(Convert.FromBase64String(encode));
            string[] uidpswd = cred.Split(':');

            var uid = uidpswd[0];
            var pswd = uidpswd[1];

            if (uid != "ritesh" || pswd != "ritesh@09")
            {
                httpContext.Response.StatusCode = 401;
                await httpContext.Response.WriteAsync("Unauthorized");
                return;
            }

            await next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class AuthMiddlewareExtensions
    {
        public static IApplicationBuilder UseAuthMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AuthMiddleware>();
        }
    }
}
