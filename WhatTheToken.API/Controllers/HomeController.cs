using Microsoft.AspNetCore.Mvc;

namespace WhatTheToken.API.Controllers;

[ApiController]
[Route("/")] // This sets the route to the root path
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Welcome to the root of the API!");
    }
}