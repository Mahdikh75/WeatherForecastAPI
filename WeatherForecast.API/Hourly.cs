using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast.API
{
    public class Hourly
    {
        public List<string> time { get; set; }
        public List<double> temperature_2m { get; set; }
        public List<int> relative_humidity_2m { get; set; }
        public List<double> dew_point_2m { get; set; }
        public List<double> apparent_temperature { get; set; }
        public List<int> precipitation_probability { get; set; }
        public List<double> precipitation { get; set; }
        public List<double> rain { get; set; }
        public List<double> showers { get; set; }
        public List<double> snowfall { get; set; }
        public List<double> snow_depth { get; set; }
        public List<int> weather_code { get; set; }
        public List<double> pressure_msl { get; set; }
        public List<double> surface_pressure { get; set; }
        public List<int> cloud_cover { get; set; }
        public List<int> cloud_cover_low { get; set; }
        public List<int> cloud_cover_mid { get; set; }
        public List<int> cloud_cover_high { get; set; }
        public List<double> visibility { get; set; }
        public List<double> evapotranspiration { get; set; }
        public List<double> et0_fao_evapotranspiration { get; set; }
        public List<double> vapour_pressure_deficit { get; set; }
        public List<double> wind_speed_10m { get; set; }
        public List<double> wind_speed_80m { get; set; }
        public List<double> wind_speed_120m { get; set; }
        public List<double> wind_speed_180m { get; set; }
        public List<int> wind_direction_10m { get; set; }
        public List<int> wind_direction_80m { get; set; }
        public List<int> wind_direction_120m { get; set; }
        public List<int> wind_direction_180m { get; set; }
        public List<double> wind_gusts_10m { get; set; }
        public List<double> temperature_80m { get; set; }
        public List<double> temperature_120m { get; set; }
        public List<double> temperature_180m { get; set; }
        public List<double> soil_temperature_0cm { get; set; }
        public List<double> soil_temperature_6cm { get; set; }
        public List<double> soil_temperature_18cm { get; set; }
        public List<double> soil_temperature_54cm { get; set; }
        public List<double> soil_moisture_0_to_1cm { get; set; }
        public List<double> soil_moisture_1_to_3cm { get; set; }
        public List<double> soil_moisture_3_to_9cm { get; set; }
        public List<double> soil_moisture_9_to_27cm { get; set; }
        public List<double> soil_moisture_27_to_81cm { get; set; }
    }

    public class HourlyUnits
    {
        public string time { get; set; }
        public string temperature_2m { get; set; }
        public string relative_humidity_2m { get; set; }
        public string dew_point_2m { get; set; }
        public string apparent_temperature { get; set; }
        public string precipitation_probability { get; set; }
        public string precipitation { get; set; }
        public string rain { get; set; }
        public string showers { get; set; }
        public string snowfall { get; set; }
        public string snow_depth { get; set; }
        public string weather_code { get; set; }
        public string pressure_msl { get; set; }
        public string surface_pressure { get; set; }
        public string cloud_cover { get; set; }
        public string cloud_cover_low { get; set; }
        public string cloud_cover_mid { get; set; }
        public string cloud_cover_high { get; set; }
        public string visibility { get; set; }
        public string evapotranspiration { get; set; }
        public string et0_fao_evapotranspiration { get; set; }
        public string vapour_pressure_deficit { get; set; }
        public string wind_speed_10m { get; set; }
        public string wind_speed_80m { get; set; }
        public string wind_speed_120m { get; set; }
        public string wind_speed_180m { get; set; }
        public string wind_direction_10m { get; set; }
        public string wind_direction_80m { get; set; }
        public string wind_direction_120m { get; set; }
        public string wind_direction_180m { get; set; }
        public string wind_gusts_10m { get; set; }
        public string temperature_80m { get; set; }
        public string temperature_120m { get; set; }
        public string temperature_180m { get; set; }
        public string soil_temperature_0cm { get; set; }
        public string soil_temperature_6cm { get; set; }
        public string soil_temperature_18cm { get; set; }
        public string soil_temperature_54cm { get; set; }
        public string soil_moisture_0_to_1cm { get; set; }
        public string soil_moisture_1_to_3cm { get; set; }
        public string soil_moisture_3_to_9cm { get; set; }
        public string soil_moisture_9_to_27cm { get; set; }
        public string soil_moisture_27_to_81cm { get; set; }
    }

}