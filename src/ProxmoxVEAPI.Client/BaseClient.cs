using ProxmoxVEAPI.Client.Core;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProxmoxVEAPI.Client
{
    public class BaseClient
    {
        protected HttpClient GetHttpClient()
        {
            var client = new HttpClient()
            {
                BaseAddress = new Uri(ConfigureClient.BaseUri)
            };

            client.DefaultRequestHeaders.Remove("Authorization");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", ConfigureClient.AccessToken);

            return client;
        }

        protected async Task<T[]> GetAsync<T>(string uri)
        {
            var client = GetHttpClient();

            var httpResponse = await client.GetAsync(uri);
            httpResponse.EnsureSuccessStatusCode();

            var response = ExtractResponse<T>(await httpResponse.Content.ReadAsStringAsync());

            return response.Data;
        }

        protected async Task<T> GetOneAsync<T>(string uri)
        {
            var client = GetHttpClient();

            var httpResponse = await client.GetAsync(uri);
            httpResponse.EnsureSuccessStatusCode();

            var response = ExtractSingleResponse<T>(await httpResponse.Content.ReadAsStringAsync());

            return response.Data;
        }

        protected BasicProxmoxResponse<T> ExtractResponse<T>(string content)
        {
            return JsonSerializer.Deserialize<BasicProxmoxResponse<T>>(content);
        }

        protected BasicProxmoxSingleResponse<T> ExtractSingleResponse<T>(string content)
        {
            return JsonSerializer.Deserialize<BasicProxmoxSingleResponse<T>>(content);
        }
    }
}
