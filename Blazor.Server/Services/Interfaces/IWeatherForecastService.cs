using Blazor.Server.Models;

using System.Threading.Tasks;

namespace Blazor.Server.Services.Interfaces
{
    internal interface IWeatherForecastService
    {
        Task<WeatherForecast[]> GetForecastAsync();
    }
}