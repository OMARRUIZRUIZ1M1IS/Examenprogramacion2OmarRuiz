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
    public partial class FrmMain : Form


    {
        public WeatherForeCast.ForeCastInfo wfc;
        public List<Coordenadas> cd;
        public HttpOpenWeatherClient httpOpenWeatherClient;
        //public OpenWeather openWeather;
       
        double x, y;
        long dt = DateTimeOffset.Now.ToUnixTimeSeconds();
      
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

                x = cd[0].lat;
                y = cd[0].lon;
                Task.Run(Request2).Wait();
                if (wfc == null)
                {
                    throw new NullReferenceException("Fallo al obtener el objeto OpeWeather.");
                }
                double tempxd = wfc.current.temp - 273.15;
                WeatherPanel weatherPanel = new WeatherPanel();
                weatherPanel.x = x;
                weatherPanel.y = y;
                weatherPanel.lblCity.Text = textBox1.Text;
                weatherPanel.lblTemperature.Text = (int)tempxd + "C";
                weatherPanel.lblWeather.Text = wfc.current.weather[0].main;
                weatherPanel.pictureBox1.ImageLocation = $"{AppSettings.ApiIcon}" + wfc.current.weather[0].icon + ".png";
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
            cd = await httpOpenWeatherClient.GetLatLong(textBox1.Text);
        }
        public async Task Request2()
        {
            wfc = await httpOpenWeatherClient.GetWeatherByGeo(x, y, dt);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
           





        }

        private void flpContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
