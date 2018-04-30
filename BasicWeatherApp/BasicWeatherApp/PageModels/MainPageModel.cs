using System;
using BasicWeatherApp.Services;

namespace BasicWeatherApp.PageModels
{
    public class MainPageModel
    {
        private string zipCode;
        public string ZipCode
        {
           get { return zipCode; }
           set { zipCode = value; }
        }
        public MainPageModel()
        {
            GetWeather();              
        }
        
        public async void GetWeather()
        {
           DataService service = new DataService();
            ZipCode = "32444";
           string url = "http://api.openweathermap.org/data/2.5/weather?zip=" + ZipCode + ",us&appid=031cc353eaafe9f58dfeac13d7cbe31a&units=imperial"; 
            var response = await service.GetAsync(url);   
            
            if(response != null){}
        }
    }
}
