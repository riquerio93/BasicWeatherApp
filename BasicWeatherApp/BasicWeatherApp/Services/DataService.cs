using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BasicWeatherApp.Services
{
    public class DataService : IDataService
    {
        public DataService()
        {
        }

        public async Task<object> GetFromEndpointAsync(string queryUrl)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(queryUrl);
            
            if(response != null)
            {
               var json = response.Content.ReadAsStringAsync().Result;
               return JsonConvert.DeserializeObject(json);
            }

            return null;
        }
    }
}
