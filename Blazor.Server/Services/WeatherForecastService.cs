using Blazor.Server.Models;
using Blazor.Server.Services.Interfaces;

using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Blazor.Server.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        public async Task<WeatherForecast[]> GetForecastAsync()
        {
            using (var stream = new StreamReader("wwwroot/Data/weather.json"))
            {
                WeatherForecast[] items = JsonSerializer.Deserialize<WeatherForecast[]>(await stream.ReadToEndAsync());
                if (items == default)
                    return new WeatherForecast[] { };

                return items;
            }
        }
    }
}