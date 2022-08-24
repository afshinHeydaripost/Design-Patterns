using System.Text;
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
            // StringBuilder sb = new StringBuilder("Suresh");
            // sb.Append(", Rohini");
            // sb.Append(", Trishika");
            // var x=sb.ToString();
            // Console.WriteLine(sb.ToString());
            // return Ok(sb);
            // string res = "";
            // double cast = 0;
            // Beverage beverage = new Espersso();
            // res = beverage.getDescription();
            // cast += beverage.cost();
            // beverage = new mocha(beverage);
            // res += beverage.getDescription();
            // cast += beverage.cost();
            // return Ok(res + "$" + cast);


            CarCreator carClassCreator = new();
            ICar car = carClassCreator.CreatCar(CarClass.Van);
            return Ok(car.GetCarClass());


        }
    }
}