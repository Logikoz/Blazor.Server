using System;
using System.Threading.Tasks;

namespace Blazor.Server.Data.Interfaces
{
    internal interface IWeatherForecastService
    {
        Task<WeatherForecast[]> GetForecastAsync();
    }
}