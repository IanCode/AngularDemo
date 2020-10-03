//-----------------------------------------------------------------------------
// FILE:	    BaseController.cs
// CONTRIBUTOR: Ian White
// COPYRIGHT:   MIT

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WeatherService.Controllers
{
    [ApiController]
    public class BaseController : ControllerBase
    {
        public BaseController(
            IHttpClientFactory httpClientFactory,
            ILogger<BaseController> logger)
        {
        }
        
    }
}