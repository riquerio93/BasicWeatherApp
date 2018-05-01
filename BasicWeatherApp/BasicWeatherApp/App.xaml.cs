using BasicWeatherApp.PageModels;
using BasicWeatherApp.Pages;
using BasicWeatherApp.Services;
using Xamarin.Forms;

namespace BasicWeatherApp
{
    public partial class App : Application
    {
        private static LocalDatabase database;
        public static LocalDatabase Database
        {
            get 
            { 
                if (database == null) 
                    database = new LocalDatabase(DependencyService.Get<IDatabaseHelper>().GetNativePath("dbFavoriteLocations.db3"));
                return database;
            }
        }

        private static string currentPage;
        public static string CurrentPage
        {
            get { return currentPage; }
            set { currentPage = value; }
        }
        
        public App()
        {
            InitializeComponent();
            
            CurrentPage = "master";
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
