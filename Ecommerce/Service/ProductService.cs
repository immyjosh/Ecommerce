using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ecommerce
{
    public class ProductService
    {
        private const string Url = "http://thingspeakapi.tk/public/api/customer";
        private HttpClient _client = new HttpClient();

        public async Task<ApiModel> GetProducts(string id){
            var response = await _client.GetAsync($"{Url}/{id}");

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                return null;

            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiModel>(content);
        }
    }
}
