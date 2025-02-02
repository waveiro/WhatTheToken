using Microsoft.EntityFrameworkCore;
using WhatTheToken.API.Data;

var builder = WebApplication.CreateBuilder(args);

const string connectionString = "Host=127.0.0.1;Port=5432;Database=weatherdb;Username=postgres;Password=postgres";
builder.Services.AddDbContext<WeatherDbContext>(options => options.UseNpgsql(connectionString));

// Add services to the container.
builder.Services.AddControllers();

var app = builder.Build();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<WeatherDbContext>();
    dbContext.Database.Migrate();
    SeedDatabase.Initialize(dbContext);
}

app.Run();