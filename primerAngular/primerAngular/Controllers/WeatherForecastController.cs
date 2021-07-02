using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace primerAngular.Controllers
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

        /*[HttpGet]
        public List<WeatherForecast> Get()
        {
            List<WeatherForecast> lista = new List<WeatherForecast>();
            var rng = new Random();

            WeatherForecast ob = new WeatherForecast();
            ob.Date = DateTime.Now.AddDays(1);
            ob.TemperatureC =  rng.Next(-20, 55);
            ob.Summary = Summaries[rng.Next(Summaries.Length)];
            lista.Add(ob);

            WeatherForecast ob1 = new WeatherForecast();
            ob1.Date = DateTime.Now.AddDays(2);
            ob1.TemperatureC = rng.Next(-20, 55);
            ob1.Summary = Summaries[rng.Next(Summaries.Length)];
            lista.Add(ob1);

            WeatherForecast ob2 = new WeatherForecast();
            ob2.Date = DateTime.Now.AddDays(3);
            ob2.TemperatureC = rng.Next(-20, 55);
            ob2.Summary = Summaries[rng.Next(Summaries.Length)];
            lista.Add(ob2);

            return lista;
            
        }*/
        [HttpGet]
        public List<int> ListaEnteros()
        {
            List<int> lista = new List<int>();

            lista.Add(1);
            lista.Add(4);
            lista.Add(6);

            return lista;
        }

    }
}
