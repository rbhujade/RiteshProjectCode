namespace CustomeMiddleware.Middleware
{
    public class CustomMiddleware(RequestDelegate reqDelegate)
    {
        private readonly RequestDelegate next = reqDelegate;

        public async Task InvokeAsunc(HttpContext context)
        {
            // Do your stuff here

            await next(context);
        }
    }

    public static class CustomMiddlewareExtension
    {
        public static IApplicationBuilder UseCustomMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<CustomMiddleware>();
        }
    }
}
