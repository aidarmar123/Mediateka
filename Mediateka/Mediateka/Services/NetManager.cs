using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Services
{
   public static class NetManager
    {
        public static readonly string URL = "https://www.cbr-xml-daily.ru/latest.js";
        public static HttpClient httpClient = new HttpClient();
        
        public static async Task<T> Get<T>(string path)
        {
            var response = await httpClient.GetAsync(URL+path);
            var content = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<T>(content);
            return data;
        }
    }
}
