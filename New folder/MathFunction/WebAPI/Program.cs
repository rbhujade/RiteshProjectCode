using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
using WebAPI.Repository;
using WebAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
builder.Services.AddDbContext<ProductDbContext>(option => 
    option.UseSqlServer(builder.Configuration.GetConnectionString("ProductDbConn")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseMiddleware<AuthenticationMiddleware>();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.UseAuthorization();

app.MapControllers();

app.Run();
