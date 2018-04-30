using System;
using System.Collections.Generic;
using BasicWeatherApp.PageModels;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace BasicWeatherApp.Pages
{
    public partial class WeatherMapPage : BasePage
    {
        private WeatherMapPageModel parentModel;

        public WeatherMapPage(WeatherMapPageModel parentModel)
        {
            InitializeComponent();
            this.parentModel = parentModel;

            Position zipPosition = new Position(Double.Parse(parentModel.Weather.Lat), Double.Parse(parentModel.Weather.Lon));
            WeatherMap.MoveToRegion(
                MapSpan.FromCenterAndRadius(zipPosition, Distance.FromMiles(0.3)));

            var pin = new Pin
            {
                Type = PinType.Place,
                Position = zipPosition,
                Label = " test",
                Address = "test"
            };

            pin.Clicked += Pin_Clicked;

            WeatherMap.Pins.Add(pin);

            MapWeatherDataToUI();
        }

        private void Pin_Clicked(object sender, EventArgs e)
        {
           //Navigation.PushAsync();
        }

        public void MapWeatherDataToUI()
        {
        }
    }
}
