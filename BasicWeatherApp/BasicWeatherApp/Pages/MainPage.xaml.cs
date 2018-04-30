using System;
using System.Collections.Generic;
using BasicWeatherApp.PageModels;
using Xamarin.Forms;

namespace BasicWeatherApp.Pages
{
    public partial class MainPage : BasePage
    {
        private MainPageModel parentModel;
        
        public MainPage(MainPageModel parentModel)
        {
            InitializeComponent();

            this.parentModel = parentModel;
        }

        void Handle_Completed(object sender, System.EventArgs e)
        {
            if(ZipCodeEntry.Text.Length == 5)
            {
               parentModel.ZipCode = ZipCodeEntry.Text;
                if (parentModel.Weather != null)
                    Navigation.PushAsync(new NavigationPage(new WeatherMapPage(new WeatherMapPageModel(parentModel.Weather)))); 
            }
        }
    }
}
