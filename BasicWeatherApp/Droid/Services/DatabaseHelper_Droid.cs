using System;
using System.IO;
using BasicWeatherApp.Droid.Services;
using BasicWeatherApp.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(DatabaseHelper_Droid))]
namespace BasicWeatherApp.Droid.Services
{
    public class DatabaseHelper_Droid : IDatabaseHelper
    {
        public string GetNativePath(string fileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, fileName);
        }
    }
}
