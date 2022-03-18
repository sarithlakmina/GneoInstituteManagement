using GneoCommonDataLibrary.Configurations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GneoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static InfoConfig configs;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, InfoConfig Configs)
        {
            _logger = logger;
            configs = Configs;

        }

        [HttpGet]
        public string Get()
        {
            return configs.Author;
        }
    }
}
