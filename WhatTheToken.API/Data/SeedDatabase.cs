namespace WhatTheToken.API.Data;

public static class SeedDatabase
{
    public static void Initialize(WeatherDbContext context)
    {
        if (context.WeatherForecasts.Any()) return;
        
        var summaries = new[] { "Congelante", "Frio", "Agradável", "Morno", "Quente", "Escaldante" };

        var forecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = summaries[Random.Shared.Next(summaries.Length)]
        }).ToList();

        context.WeatherForecasts.AddRange(forecasts);
        context.SaveChanges();
    }
}