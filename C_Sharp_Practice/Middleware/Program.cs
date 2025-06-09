using Microsoft.Graph.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseCustomAuthentication(); // Add this before secured endpoints

app.MapGet("/", () => "Welcome to secure API!");

app.Run();