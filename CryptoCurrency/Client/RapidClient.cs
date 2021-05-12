using CryptoCurrency.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CryptoCurrency.Client
{
    public class RapidClient : IRapidClient
    {
        private readonly HttpClient _client;
        private const string Client = "RapidClient";
        public RapidClient(IHttpClientFactory httpClientFactory)
        {
            _client = httpClientFactory.CreateClient(Client);
        }
        private List<int> ids = new List<int>() { 1, 8, 4, 7 };
        public async Task<List<Coins.Coin>> GetAsync()
        {
            var request = new HttpRequestMessage { Method = HttpMethod.Get };
            using (var response = await _client.SendAsync(request))
            {
                try
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    Coins result = JsonConvert.DeserializeObject<Coins>(body);
                    var result2 = result.data.coins.Where(x => ids.Contains(x.id)).ToList();
                    return result2;
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
