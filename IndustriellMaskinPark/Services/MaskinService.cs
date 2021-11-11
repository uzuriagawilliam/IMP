using IndustriellMaskinPark.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IndustriellMaskinPark.Services
{
    public class MaskinService : IMaskinService
    {
        private readonly HttpClient _httpClient;
        public MaskinService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Maskin> AddMaskin(Maskin maskin)
        {
            var maskinJson = new StringContent(JsonSerializer.Serialize(maskin), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/maskins", maskinJson);
            //if(response.IsSuccessStatusCode)
            //{
            //    return await JsonSerializer.DeserializeAsync<Maskin>(await response.Content.ReadAsStreamAsync());
            //}
            return null;            
        }

        public async Task DeleteMaskin(int id)
        {
            await _httpClient.DeleteAsync($"api/maskin/{id}");
        }

        public async Task<IEnumerable<Maskin>> GetAllMaskins()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Maskin>>
                (await _httpClient.GetStreamAsync($"api/maskins"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });            
        }

        public async Task<Maskin> GetMaskinsDetails(int maskinId)
        {
            return await JsonSerializer.DeserializeAsync<Maskin>
                 (await _httpClient.GetStreamAsync($"api/maskins/{maskinId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        public async Task UpdateMaskins(Maskin maskin)
        {
            var maskinJson = new StringContent(JsonSerializer.Serialize(maskin), Encoding.UTF8, "application/json");
            await _httpClient.PutAsync("api/maskin", maskinJson);
        }
    }

}
