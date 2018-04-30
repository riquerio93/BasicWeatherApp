using System;
using System.Threading.Tasks;

namespace BasicWeatherApp.Services
{
    public interface IDataService
    {
        Task<object> GetAsync(string queryUrl); 
    }
}
