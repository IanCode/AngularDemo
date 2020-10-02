//-----------------------------------------------------------------------------
// FILE:	   WeatherController.cs
// CONTRIBUTOR: Ian White
// COPYRIGHT:   MIT

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WeatherService.Controllers
{
    #region snippet_ControllerSignature
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    #endregion
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherController> _logger;

        public WeatherController(ILogger<WeatherController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string GetWeatherData()
        {
            return "not implemented";
        }

        // Gets the number of rainy days in the past month for a given location.
        [HttpGet]
        public List<string> GetRainyDays()
        {
            return new List<string>{"Monday", "Thursday"};
        }
    }
}