using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeatherConcurrencyApp.Common;
using WeatherConcurrentApp.Domain.Entities;
using WeatherConcurrentApp.Domain.Interfaces;

namespace WeatherConcurrencyApp.Infrastructure.OpenWeatherClient
{
    public class HttpOpenWeatherClient : IHttpOpenWeatherClient
    {
        public async Task<List<Coordenadas>> GetLatLong(string city)
        {

            string url = $"{AppSettings.ApiUrlgeo}{city}&limit=1&appid={AppSettings.Token}";
            string jsonObject = string.Empty;
            try
            {

                using (HttpClient httpClient = new HttpClient())
                {
                    jsonObject = await httpClient.GetAsync(url).Result.Content.ReadAsStringAsync();
                }

                if (string.IsNullOrEmpty(jsonObject))
                {
                    throw new NullReferenceException("El objeto json no puede ser null.");
                }
                List<Coordenadas> crd = new List<Coordenadas>();
                crd = JsonConvert.DeserializeObject<List<Coordenadas>>(jsonObject);
                return crd;
                //return Newtonsoft.Json.JsonConvert.DeserializeObject<List<co>>(jsonObject);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public async Task<WeatherForeCast.ForeCastInfo> GetWeatherByGeo(double x, double y, long dt)
        {
            string url = $"{AppSettings.ApiUrl}lat={x}&lon={y}&dt={dt}&appid={AppSettings.Token}";
            string jsonObject = string.Empty;
            //WeatherForeCast.ForeCastInfo fr
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    jsonObject = await httpClient.GetAsync(url).Result.Content.ReadAsStringAsync();
                }

                if (string.IsNullOrEmpty(jsonObject))
                {
                    throw new NullReferenceException("El objeto json no puede ser null.");
                }

                //return Newtonsoft.Json.JsonConvert.DeserializeObject<OpenWeather>(jsonObject);
                return Newtonsoft.Json.JsonConvert.DeserializeObject<WeatherForeCast.ForeCastInfo>(jsonObject);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
