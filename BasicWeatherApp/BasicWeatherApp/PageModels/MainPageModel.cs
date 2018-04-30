using System;
using System.Threading.Tasks;
using BasicWeatherApp.Models;
using BasicWeatherApp.Pages;
using BasicWeatherApp.Services;
using Xamarin.Forms;

namespace BasicWeatherApp.PageModels
{
    public class MainPageModel 
    {
        private string zipCode;
        public string ZipCode
        {
           get { return zipCode; }
           set { zipCode = value;
                Task.Run(GetWeather).Wait();
           }
        }

        private WeatherData weather;
        public WeatherData Weather
        {
            get { return weather; }
            set { weather = value; }
        }
        
        public MainPageModel()
        {             
        }
        
        public async Task<WeatherData> GetWeather()
        {
           DataService service = new DataService();
           string key = "031cc353eaafe9f58dfeac13d7cbe31a";
           string url = "http://api.openweathermap.org/data/2.5/weather?zip=" + ZipCode + ",us&appid=" + key + "&units=imperial"; 
           dynamic response = await service.GetAsync(url);   
            
           if(response != null)
           {
              Weather = new WeatherData();  
              Weather.Title = (string)response["name"];                  
              Weather.Temperature = (string)response["main"]["temp"] + " F";  
              Weather.Wind = (string)response["wind"]["speed"] + " mph";                  
              Weather.Humidity = (string)response["main"]["humidity"] + " %";  
              Weather.Visibility = (string)response["weather"][0]["main"];
              Weather.Lat = (string)response["coord"]["lat"];
              Weather.Lon = (string)response["coord"]["lon"];

              /*  DateTime time = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);  
                DateTime sunrise = time.AddSeconds((double)results["sys"]["sunrise"]);  
                DateTime sunset = time.AddSeconds((double)results["sys"]["sunset"]);  
                weather.Sunrise = sunrise.ToString() + " UTC";  
                weather.Sunset = sunset.ToString() + " UTC";  */
                return Weather; 
           }
            return null;
        }
        
       
    }
}
