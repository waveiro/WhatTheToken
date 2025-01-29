namespace WhatTheToken.API;

public class WeatherForecast
{
    public int Id { get; set; }
    public DateOnly Date { get; set; }
    public int TemperatureC { get; set; }
    public string? Summary { get; set; }
    public string Version => "2.0";
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}