using Microsoft.AspNetCore.Diagnostics;

namespace CustomeMiddleware.ExceptionHandling
{

    public static class GlobalException
    {
        public static void UseGlobalExceptionHandler(this IApplicationBuilder app, IWebHostEnvironment env) 
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler(
                    options =>
                    {  
                        options.Run(
                            async context =>
                            {
                                context.Response.StatusCode = 500;
                                var ex = context.Features.Get<IExceptionHandlerFeature>();

                                if (ex != null)
                                {
                                    await context.Response.WriteAsync(ex.Error.Message);
                                }
                            }
                            );
                    }
                    );
            }
        } 
    }
}
