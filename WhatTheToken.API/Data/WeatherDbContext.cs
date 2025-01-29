using Microsoft.EntityFrameworkCore;

namespace WhatTheToken.API.Data;

public class WeatherDbContext : DbContext
{
    public WeatherDbContext(DbContextOptions<WeatherDbContext> options) : base(options) { }
    public DbSet<WeatherForecast> WeatherForecasts { get; set; }
}