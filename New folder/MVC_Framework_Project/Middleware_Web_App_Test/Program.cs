var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


//app.MapGet("/", () => "Hello World!");

app.Use(async (context, next) =>
{
    app.Logger.LogInformation("MW : Incoming Request.");
    await next();
    app.Logger.LogInformation("MW : Outgoing Request.");
});

app.Run();
