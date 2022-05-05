using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeatherConcurrentApp.Domain.Entities;

namespace WeatherConcurrentApp.Domain.Interfaces
{
    public interface IHttpOpenWeatherClient
    {
        Task<WeatherForeCast.ForeCastInfo> GetWeatherByGeo(double x, double y, long dt);
        Task<List<Coordenadas>> GetLatLong(string city);

    }
}
