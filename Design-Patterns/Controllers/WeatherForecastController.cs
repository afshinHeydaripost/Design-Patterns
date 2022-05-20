using Design_Patterns.Class;
using Microsoft.AspNetCore.Mvc;

namespace Design_Patterns.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            string res = "";
            double cast = 0;
            Beverage beverage = new Espersso();
            res = beverage.getDescription();
            cast += beverage.cost();
            beverage = new mocha(beverage);
            res += beverage.getDescription();
            cast += beverage.cost();
            return Ok(res + "$" + cast);
        }
    }
}