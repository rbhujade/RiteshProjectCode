using Azure;
using Microsoft.AspNetCore.Http;

namespace WebAPI.Middleware
{
    public class AuthenticationMiddleware
    {
        private readonly RequestDelegate _requestDelegate;

        public AuthenticationMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate; 
        }

        public async Task InvokeAsync(Microsoft.AspNetCore.Http.HttpContext content)
        {
            if (!content.Request.Headers.ContainsKey("Authorization"))
            {
                content.Response.StatusCode = 401; //unauthorized
                await content.Response.WriteAsync("Authorization heading is missing");
                return;
            }

            var token = content.Request.Headers["Authorization"].ToString().Replace("Bearer " , "");

            if(token != "Valid-token")
            {
                content.Response.StatusCode = 403;
                await content.Response.WriteAsync("Invalid token");
                return;
            }

            await _requestDelegate(content);
        }
    }
}
