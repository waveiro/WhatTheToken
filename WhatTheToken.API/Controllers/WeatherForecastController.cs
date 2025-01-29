using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WhatTheToken.API.Data;

namespace WhatTheToken.API.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController(WeatherDbContext context) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<WeatherForecast>>> GetWeatherForecast()
    {
        return await context.WeatherForecasts.ToListAsync();
    }
}