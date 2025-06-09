using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Graph.Models;
using Microsoft.Graph.Models.ExternalConnectors;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Middleware
{
    class AuthenticationMiddleware
    {
        private readonly RequestDelegate _requestDelegate;
        private const string VALID_API_KEY = "your-secret-api-key";
        private const string API_KEY_HEADER_NAME = "X-Api-Key";
        private readonly string _jwtSecret;

        public AuthenticationMiddleware(RequestDelegate requestDelegate,IConfiguration configuration) 
        { 
            _requestDelegate = requestDelegate;
            _jwtSecret = configuration["Jwt:Secret"]; // Load secret from config
        }

        public async Task Invoke(HttpContext context)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (string.IsNullOrEmpty(token)) 
            {
                context.Response.StatusCode = 401; // Unauthorized
                await context.Response.WriteAsync("Unauthorized: Token missing.");
                return;
            }

            if(!ValidToken(token, out ClaimsPrincipal claimsPrincipal))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Unauthorized: Invalid token");
                return;
            }

            if (!context.Request.Headers.TryGetValue(API_KEY_HEADER_NAME,out var extractedApiKey))
            {
                context.Response.StatusCode = 401; // Unauthorized
                await context.Response.WriteAsync("API Key was not provided.");
                return;
            }

            if (!VALID_API_KEY.Equals(extractedApiKey)) 
            {
                context.Response.StatusCode = 403; //Forbidden
                await context.Response.WriteAsync("Unauthorized client.");
                return;
            }

            // Attach user info to context if needed
            context.User = claimsPrincipal;

            await _requestDelegate(context); // Call the next middleware
        }

        public bool ValidToken(string token, out ClaimsPrincipal principal)
        {
            principal = null;

            var key = Encoding.UTF8.GetBytes(_jwtSecret);

            var tokenHandler = new JwtSecurityTokenHandler();
            try
            {
                principal = tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false, // Set true in production
                    ValidateAudience = false, // Set true in production
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
