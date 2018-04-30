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
            MasterDetailPage masterPage = new MasterDetailPage
            {
                Master = new SlidePage(),
                Detail = new NavigationPage(new MainPage(pageModel))
        };
            
            MainPage = masterPage;
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
