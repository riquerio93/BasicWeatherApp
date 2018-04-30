using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BasicWeatherApp.Services
{
    public class DataService : IDataService
    {
        public DataService()
        {
        }

        public async Task<object> GetAsync(string queryUrl)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(queryUrl);
            
            if(response != null)
            {
                return response;
            }

            return null;
        }
    }
}
