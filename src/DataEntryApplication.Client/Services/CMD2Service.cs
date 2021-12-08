using DataEntryApplication.Client.Services.Interfaces;
using DataEntryApplication.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataEntryApplication.Client.Services
{
    public class CMD2Service : ICMD2Services
    {
        private readonly HttpClient _httpClient;

        public CMD2Service(HttpClient httpClient)
        {
            _httpClient = httpClient; ;
        }

        public async Task<IList<CMD2Model>> GetValuesOfCMD2()
        {
            var result = await _httpClient.GetJsonAsync<IList<CMD2Model>>("api/CMD2");

            return result;
        }

        public async Task<bool> Save(IList<CMD2Model> values, int mode)
        {
            var json = JsonSerializer.Serialize(values);
            var response = await _httpClient.PostAsync($"api/CMD2/{mode}", new StringContent(json, Encoding.UTF8, "application/json"));
            return response.IsSuccessStatusCode;
        }
    }
}