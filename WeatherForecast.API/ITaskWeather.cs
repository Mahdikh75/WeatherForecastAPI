using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast.API
{
    public interface ITaskWeather
    {
        public Task<string> Query();
    }
}