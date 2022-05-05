using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherConcurrencyApp.Infrastructure.OpenWeatherClient;
using WeatherConcurrentApp.Domain.Entities;

namespace WeatherConcurrencyApp
{
    public partial class FrmMain : Form
    {
        public HttpOpenWeatherClient httpOpenWeatherClient;
        public OpenWeather openWeather;
        public FrmMain()
        {
            httpOpenWeatherClient = new HttpOpenWeatherClient();
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Run(Request).Wait();
                if(openWeather == null)
                {
                    throw new NullReferenceException("Fallo al obtener el objeto OpeWeather.");
                }

                WeatherPanel weatherPanel = new WeatherPanel();
                weatherPanel.pictureBox1.ImageLocation = "https://openweathermap.org/img/w/" + openWeather.Weather[0].Icon + ".png";
                weatherPanel.lblCity.Text = textBox1.Text;
                weatherPanel.lblTemperature.Text = openWeather.Main.Temp.ToString() + "°C";
                weatherPanel.lblWeather.Text = "Temperature";
                weatherPanel.dtwFeelsLike.lblDetailValue.Text = openWeather.Main.Feels_like.ToString();
                weatherPanel.dtwTempMin.lblDetailValue.Text = openWeather.Main.Temp_min.ToString() + "°C";
                weatherPanel.dtwTempMax.lblDetailValue.Text = openWeather.Main.Temp_max.ToString() + "°C";
                weatherPanel.dtwPressure.lblDetailValue.Text = openWeather.Main.Pressure.ToString();
                weatherPanel.dtwHumidity.lblDetailValue.Text = openWeather.Main.Humidity.ToString();
                weatherPanel.dtwLon.lblDetailValue.Text = openWeather.Coord.Lon.ToString();
                weatherPanel.dtwLat.lblDetailValue.Text = openWeather.Coord.Lat.ToString();
                weatherPanel.dtwSpeed.lblDetailValue.Text = openWeather.Wind.Speed.ToString();
                weatherPanel.dtwVissibility.lblDetailValue.Text = openWeather.Visibility.ToString() + "m";
                weatherPanel.dtwTimeZone.lblDetailValue.Text = openWeather.Timezone.ToString();
                weatherPanel.dtwSunrise.lblDetailValue.Text = convertLongToDate(openWeather.Sys.Sunrise).ToShortTimeString();
                weatherPanel.dtwSunset.lblDetailValue.Text = convertLongToDate(openWeather.Sys.Sunset).ToShortTimeString();
                flpContent.Controls.Add(weatherPanel);
            }
            catch (Exception)
            {
                
            }
           
        }
        DateTime convertLongToDate(long date)
        {
            DateTime time = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();
            time = time.AddSeconds(date).ToLocalTime();
            return time;
        }
        public async Task Request()
        {
           openWeather = await httpOpenWeatherClient.GetWeatherByCityNameAsync(textBox1.Text);
        }
    }
}
