using System;
namespace BasicWeatherApp.Services
{
    public interface IDatabaseHelper
    {
        string GetNativePath(string fileName);
    }
}
