using System;
using System.Collections.Generic;
using BasicWeatherApp.Models;
using BasicWeatherApp.PageModels;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace BasicWeatherApp.Pages
{
    public partial class WeatherMapPage : BasePage
    {
        private WeatherMapPageModel pageModel;

        public WeatherMapPage(WeatherMapPageModel pageModel)
        {
            InitializeComponent();
            App.CurrentPage = "weathermap";
            this.pageModel = pageModel;

            Position zipPosition = new Position(Double.Parse(pageModel.Weather.Lat), Double.Parse(pageModel.Weather.Lon));
            WeatherMap.MoveToRegion(
                MapSpan.FromCenterAndRadius(zipPosition, Distance.FromMiles(0.3)));

            var pin = new Pin
            {
                Type = PinType.Place,
                Position = zipPosition,
                Label = "Temperature:Wind:Humidity:Visibility",
                Address = pageModel.Weather.Temperature + ":" +
                          pageModel.Weather.Wind + ":" +
                          pageModel.Weather.Humidity + ":" +
                          pageModel.Weather.Visibility
            };

            pin.Clicked += Pin_Clicked;

            WeatherMap.Pins.Add(pin);

            MapWeatherDataToUI();
        }

        private async void Pin_Clicked(object sender, EventArgs e)
        {
            var shouldFavorite = await DisplayAlert("Favorite", "Would you like to favorite this location?", "yes", "no");
            
            if(shouldFavorite)
            {
                var result = await App.Database.PostItemAsync(new FavoriteLocation(){
                    Title = "FavoriteItem",
                    Lat = pageModel.Weather.Lat,
                    Lon = pageModel.Weather.Lon
                });
            }
        }

        public void MapWeatherDataToUI()
        {
        }
    }
}
