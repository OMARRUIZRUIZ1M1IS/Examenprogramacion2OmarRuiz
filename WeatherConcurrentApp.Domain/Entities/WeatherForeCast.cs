﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherConcurrentApp.Domain.Entities
{
    public class WeatherForeCast
    {
        public class temp
        {
            public double day { get; set; }
        }
        //public class rain
        //{
        //    public double 1h {get; set;}



        public class weather
        {
            public int id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }
        public class current
        {
            public long dt { get; set; }
            public int sunrise { get; set; }
            public int sunset { get; set; }
            public double temp { get; set; }
            public double feels_like { get; set; }
            public int pressure { get; set; }
            public int humidity { get; set; }
            public double dew_point { get; set; }
            public int uvi { get; set; }
            public int clouds { get; set; }
            public double wind_speed { get; set; }
            public int wind_deg { get; set; }
            public List<weather> weather { get; set; }
        }
        public class hourly
        {
            public long dt { get; set; }
            public double temp { get; set; }
            public double feels_like { get; set; }
            public int pressure { get; set; }
            public int humidity { get; set; }
            public int clouds { get; set; }
            public double wind_speed { get; set; }
            public int wind_deg { get; set; }
            public List<weather> weather { get; set; }
        }
        //public class Clouds
        //{
        //    public int All { get; set; }
        //}
        public class ForeCastInfo
        {
            public current current { get; set; }
            public List<hourly> hourly { get; set; }

        }


    }
}
