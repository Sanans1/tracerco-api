using Microsoft.AspNetCore.Mvc;
using tracerco_api.Interfaces;

namespace tracerco_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecast _forecastService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecast forecastService)
        {
            _logger = logger;
            _forecastService = forecastService;
        }

        [HttpGet]
        [Route("GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return _forecastService.GetAllForecasts();
        }

        [HttpGet]
        [Route("GetHottestForecast")]
        public WeatherForecast GetHottestForecast()
        {
            return _forecastService.GetHottestForecast();
        }
    }
}