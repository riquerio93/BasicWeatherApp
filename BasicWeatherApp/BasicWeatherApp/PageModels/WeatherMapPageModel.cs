using System;
using BasicWeatherApp.Models;

namespace BasicWeatherApp.PageModels
{
    public class WeatherMapPageModel
    {  
    
        private WeatherData weather;
        public WeatherData Weather
        {
            get { return weather; }
            set { weather = value; }
        }

        public WeatherMapPageModel(WeatherData weather)
        {
            this.weather = weather;
        }
    }
}
