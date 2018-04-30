using BasicWeatherApp.PageModels;
using BasicWeatherApp.Pages;
using Xamarin.Forms;

namespace BasicWeatherApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var pageModel = new MainPageModel();
            MainPage = new NavigationPage(new MainPage(pageModel));
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
