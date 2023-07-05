using ConnectlimeApi.Exercise;
using Microsoft.AspNetCore.Mvc;

namespace ConnectlimeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public Person Get()
        {
            Person person = new Person ("John", "x", 123);
            //person.Name = "Anna";  //cannot write a name
            //Console.WriteLine(person.NIF); // cannot access the NIF
            Console.WriteLine("Person:" + person.Name + " NIF: " + person.GetIdentificationNumber());


            return person;

            
        }
    }
}