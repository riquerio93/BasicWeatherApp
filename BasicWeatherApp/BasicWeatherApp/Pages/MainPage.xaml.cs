using System;
using System.Collections.Generic;
using BasicWeatherApp.PageModels;
using Xamarin.Forms;

namespace BasicWeatherApp.Pages
{
    public partial class MainPage : BasePage
    {
        private MainPageModel pageModel;
        
        public MainPage(MainPageModel pageModel)
        {
            InitializeComponent();
            this.pageModel = pageModel;
        }

        void Handle_Completed(object sender, System.EventArgs e)
        {
            if(ZipCodeEntry.Text.Length == 5)
            {
               pageModel.ZipCode = ZipCodeEntry.Text;
                if (pageModel.Weather != null)
                    Navigation.PushAsync(new NavigationPage(new WeatherMapPage(new WeatherMapPageModel(pageModel.Weather)))); 
            }
        }
    }
}
