//-----------------------------------------------------------------------------
// FILE:	   WeatherController.cs
// CONTRIBUTOR: Ian White
// COPYRIGHT:   MIT

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using Microsoft.Extensions.Logging;

namespace WeatherService.Controllers
{
    #region snippet_ControllerSignature
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : BaseController
    #endregion
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private HttpClient openWeatherClient;

        private string API_KEY;

        public WeatherController(
            IHttpClientFactory httpClientFactory,
            ILogger<WeatherController> logger)
            : base(
                httpClientFactory, 
                logger)
        {
            openWeatherClient = httpClientFactory.CreateClient("openWeatherClient");

            API_KEY = "37d41032bf3cbf7e7e0ee16f62123cc5";
        }

        [HttpGet]
        [Route("data")]
        public async Task<JObject> GetWeatherDataAsync()
        {
            var response = await openWeatherClient.GetAsync($"/data/2.5/weather?q=London&appid={API_KEY}");

            var result = await response.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<JObject>(result.ToString());

            return data;
        }

        // Gets the number of rainy days in the past month for a given location.
        [HttpGet]
        [Route("rainydays")]
        public List<string> GetRainyDays()
        {
            return new List<string>{"Monday", "Thursday"};
        }
    }
}