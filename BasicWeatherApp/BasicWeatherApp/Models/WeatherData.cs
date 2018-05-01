using System;
namespace BasicWeatherApp.Models
{
    public class WeatherData
    {
        public string Title { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public string Humidity { get; set; }
        public string Temperature { get; set; }
        public string Wind { get; set; }
        public string Visibility { get; set; }
        
        public WeatherData()
        {
            Title = "";
            Lat = "";
            Lon = "";
            Humidity = "";
            Temperature = "";
            Wind = "";
            Visibility = "";
        }
    }
}
