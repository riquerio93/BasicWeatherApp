using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BasicWeatherApp.Models;
using Xamarin.Forms;

namespace BasicWeatherApp.Pages
{
    public partial class SlidePage : ContentPage
    {
        ObservableCollection<Favorites> FavoritesList; 
        public SlidePage()
        {
            InitializeComponent();
            FavoritesList = new ObservableCollection<Favorites>();

            if (App.CurrentPage.Equals("weathermap"))
            {
                Title = "WeatherData";
            }
            else
            {
                Title = "Favorites";
            }

            GetFavorites();
            //GetWeatherData();
        }

        public async void GetFavorites()
        {
           if(Title.Equals("Favorites"))
            {
                var favorites = await App.Database.GetItemsAsync();
                
                if(favorites != null && favorites.Count > 0) 
                {
                    foreach (var item in favorites)
                    {
                        FavoritesList.Add(new Favorites() { Favorite = item });
                    }

                    FavList.ItemsSource = FavoritesList;
                }
            }
        }
        
        public void GetWeatherData()
        {
        
        }
    }
}
