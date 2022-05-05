using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherConcurrencyApp.Common;
using WeatherConcurrencyApp.Infrastructure.OpenWeatherClient;
using WeatherConcurrentApp.Domain.Entities;

namespace WeatherConcurrencyApp
{
    public partial class WeatherPanel : UserControl
    {

        public WeatherForeCast.ForeCastInfo wfc2;
        public HttpOpenWeatherClient opw;
        public List<Coordenadas> cd;
        public double x, y;
        long dt = DateTimeOffset.Now.ToUnixTimeSeconds();

        public WeatherPanel()
        {


            opw = new HttpOpenWeatherClient();
            InitializeComponent();
        }

        private void WeatherPanel_Load(object sender, EventArgs e)
        {
            Task.Run(Request).Wait();
            Task.Run(Request2).Wait();
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            DateTime day1 = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();

            DetailsWeather detailsWeather = new DetailsWeather();
            detailsWeather.lblDetail.Text = "Details";
            detailsWeather.lblDetailValue.Text = wfc2.current.weather[0].description;
            flpContent.Controls.Add(detailsWeather);

            DetailsWeather detailsWeather1 = new DetailsWeather();
            detailsWeather1.lblDetail.Text = "amanecer";
            day = day.AddSeconds(wfc2.current.sunrise).ToLocalTime();
            detailsWeather1.lblDetailValue.Text = day.ToShortTimeString();
            flpContent.Controls.Add(detailsWeather1);

            DetailsWeather detailsWeather2 = new DetailsWeather();
            detailsWeather2.lblDetail.Text = "atardecer";
            day1 = day1.AddSeconds(wfc2.current.sunset).ToLocalTime();
            detailsWeather2.lblDetailValue.Text = day1.ToShortTimeString();
            flpContent.Controls.Add(detailsWeather2);

            DetailsWeather detailsWeather3 = new DetailsWeather();
            detailsWeather3.lblDetail.Text = "Wind Speed";
            detailsWeather3.lblDetailValue.Text = wfc2.current.wind_speed.ToString() + " Km/h";
            flpContent.Controls.Add(detailsWeather3);

            DetailsWeather detailsWeather4 = new DetailsWeather();
            detailsWeather4.lblDetail.Text = "Pressure";
            detailsWeather4.lblDetailValue.Text = wfc2.current.pressure.ToString();
            flpContent.Controls.Add(detailsWeather4);

            DetailsWeather detailsWeather5 = new DetailsWeather();
            detailsWeather5.lblDetail.Text = "Humidity";
            detailsWeather5.lblDetailValue.Text = wfc2.current.humidity.ToString() + "%";
            flpContent.Controls.Add(detailsWeather5);


            UserControl1 segundo;

            for (int i = 0; i < 5; i++)
            {
                double temp;
                int tempint;
                string hoursstring;
                temp = wfc2.hourly[i].temp - 273.15;
                hoursstring = ConvertDateTime(wfc2.hourly[i].dt).ToShortTimeString();
                tempint = (int)temp;
                segundo = new UserControl1();
               
                segundo.label2.Text = wfc2.hourly[i].weather[0].main;
                segundo.label3.Text = wfc2.hourly[i].weather[0].description;
                segundo.label4.Text = wfc2.hourly[i].wind_speed.ToString();
                segundo.label5.Text = wfc2.hourly[i].pressure.ToString();
                segundo.label6.Text = tempint.ToString() + "C";
                segundo.WeatherIcon.ImageLocation = $"{AppSettings.ApiIcon}" + wfc2.hourly[i].weather[0].icon + ".png";
                flpContent.Controls.Add(segundo);
            }









        }

        private void flpContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTemperature_Click(object sender, EventArgs e)
        {

        }

        private void detailsWeather2_Load(object sender, EventArgs e)
        {

        }

        private void detailsWeather9_Load(object sender, EventArgs e)
        {

        }

        private void dtwFeelsLike_Load(object sender, EventArgs e)
        {

        }

        private void lblWeather_Click(object sender, EventArgs e)
        {

        }

        private void lblCity_Click(object sender, EventArgs e)
        {

        }


        DateTime ConvertDateTime(long Milisec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();

            day = day.AddSeconds(Milisec).ToLocalTime();

            return day;
        }
        public async Task Request()
        {
            cd = await opw.GetLatLong(lblCity.Text);
        }
        public async Task Request2()
        {
            wfc2 = await opw.GetWeatherByGeo(x, y, dt);
        }
    }
}
