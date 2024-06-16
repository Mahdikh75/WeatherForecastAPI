using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast.API
{
    public class WeatherClient 
    {
        private double latitude = 0;
        private double longitude = 0;
        private string NameCity = string.Empty;

        public WeatherClient(string city)
        {
            this.NameCity = city;
        }

        public WeatherClient(double lat, double lg)
        {
            this.latitude = lat;
            this.longitude = lg;
        }


    }
}