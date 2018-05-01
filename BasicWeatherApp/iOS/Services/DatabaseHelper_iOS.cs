using System;
using System.IO;
using BasicWeatherApp.iOS.Services;
using BasicWeatherApp.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(DatabaseHelper_iOS))]
namespace BasicWeatherApp.iOS.Services
{
    public class DatabaseHelper_iOS : IDatabaseHelper
    {
        public string GetNativePath(string fileName)
        {
            string documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string library = Path.Combine(documents, "..", "Library", "Databases");
            
            if(!Directory.Exists(library))
            {
                Directory.CreateDirectory(library);
            }

            return Path.Combine(library,fileName);
            
        }
    }
}
