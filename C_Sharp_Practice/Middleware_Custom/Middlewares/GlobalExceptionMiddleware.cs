using Microsoft.AspNetCore.Http;
using System.Net;
using System.Text.Json;

namespace Middleware_Custom.Middlewares
{
    public class GlobalExceptionMiddleware
    {
        public readonly ILogger<GlobalExceptionMiddleware> _logger;
        public readonly RequestDelegate _requestDelegate;

        public GlobalExceptionMiddleware(RequestDelegate requestDelegate, ILogger<GlobalExceptionMiddleware> logger)
        {
            _logger = logger;
            _requestDelegate = requestDelegate;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _requestDelegate(httpContext);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error occoured :  { ex.Message}");
                await HandleException(httpContext,ex);
            }
        }

        public static Task HandleException(HttpContext httpContext, Exception ex)
        {
            var errorDetails = new ErrorDetails
            {
                StatusCode = StatusCodes.Status500InternalServerError,
                Message = "Internal server Error."
            };

            var response = JsonSerializer.Serialize(errorDetails);

            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = errorDetails.StatusCode;
            
            return httpContext.Response.WriteAsync(response);
        }

        public class ErrorDetails
        {
            public int StatusCode { get; set; }
            public string? Message { get; set; }
        }

    }
}
