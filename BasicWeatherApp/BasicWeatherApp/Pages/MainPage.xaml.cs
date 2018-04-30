using System;
using System.Collections.Generic;
using BasicWeatherApp.PageModels;
using Xamarin.Forms;

namespace BasicWeatherApp.Pages
{
    public partial class MainPage : ContentPage
    {
        private MainPageModel parentModel;
        
        public MainPage(MainPageModel parentModel)
        {
            InitializeComponent();

            this.parentModel = parentModel;
        }
    }
}
