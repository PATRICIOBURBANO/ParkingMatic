using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ParkingMatic.Data;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ParkingMaticContext>(options =>


    options.UseSqlServer(builder.Configuration.GetConnectionString("ParkingMaticContext") ?? throw new InvalidOperationException("Connection string 'ParkingMaticContext' not found.")));

// Add services to the container.


var app = builder.Build();
app.Run();

