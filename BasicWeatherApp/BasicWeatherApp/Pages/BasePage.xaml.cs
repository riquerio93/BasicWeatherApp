using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BasicWeatherApp.Pages
{
    public partial class BasePage : ContentPage
    {
        public View BaseContent
        {
            get { return BaseContentView.Content; }
            set { BaseContentView.Content = value; }
        }
        
        public BasePage()
        {
            InitializeComponent();
        }
    }
}
