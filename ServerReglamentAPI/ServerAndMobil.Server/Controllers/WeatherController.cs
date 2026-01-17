using Microsoft.AspNetCore.Mvc;
using TriangleDocker.dataBasa;

namespace ServerAndMobil.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherController> _logger;
        private readonly AppDBcontent _context;

        public WeatherController(ILogger<WeatherController> logger, AppDBcontent context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "GetWeather")]
        public IEnumerable<Weather> Get()
        {
            var scoreList = _context.Score.ToList();

            var kol = 99;

            return Enumerable.Range(1, 5).Select(index => new Weather
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
