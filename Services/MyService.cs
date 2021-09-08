using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using HelloTraveller.Models;

namespace HelloTraveller.Services
{
    public class MyService : IMyService
    {
        private readonly HttpClient _httpClient;

        public MyService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<Result[]> GetAllData()
        {
            return await _httpClient.GetFromJsonAsync<Result[]>(
                $"/photos?client_id=c4I6ZaBshiMSv3UB2Q6b8hcFHLCyRKcOZ4BLhGJtgGk");
        }

        public async Task<Topics[]> GetTopics()
        {
            return await _httpClient.GetFromJsonAsync<Topics[]>(
                $"/topics?client_id=c4I6ZaBshiMSv3UB2Q6b8hcFHLCyRKcOZ4BLhGJtgGk");
        }

        public async Task<MyModelClass> SearchPhotos(string search)
        {
            var searchParam = $"&query={search}";
            if (string.IsNullOrEmpty(search))
            {
                searchParam = "";
            }

            return await _httpClient.GetFromJsonAsync<MyModelClass>(
                $"search/photos?page=1{searchParam}&client_id=c4I6ZaBshiMSv3UB2Q6b8hcFHLCyRKcOZ4BLhGJtgGk");
        }
    }
}