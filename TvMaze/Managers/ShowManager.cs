using Newtonsoft.Json;
using TvMaze.Web.Managers.Interfaces;
using TvMaze.Web.Models;

namespace TvMaze.Web.Managers
{
    public class ShowManager : IShowManager
    {
        private readonly IConfiguration _configuration;
        static HttpClient client = new HttpClient();
        
        public ShowManager(IConfiguration configuration) 
        {
            _configuration = configuration;
        }

        public async Task<Root> GetShowResultsAsync() {
            var path = _configuration.GetValue<string>("WebApiUrl");
            HttpResponseMessage httpResponseMessage = await client.GetAsync(path);
            if (httpResponseMessage.IsSuccessStatusCode) { 
                var output = await httpResponseMessage.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Root>(output);
            }
            return new Root();
        }
    }
}
