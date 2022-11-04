using tracerco_api.Interfaces;

namespace tracerco_api.Services
{
    public class WeatherForecastService : IWeatherForecast
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly IEnumerable<WeatherForecast> WeatherForecasts;

        public WeatherForecastService ()
        {
            WeatherForecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            });
        }

        public IEnumerable<WeatherForecast> GetAllForecasts()
        {
            return WeatherForecasts.ToArray();
        }

        public WeatherForecast GetHottestForecast()
        {
            throw new NotImplementedException();
        }
    }
}
