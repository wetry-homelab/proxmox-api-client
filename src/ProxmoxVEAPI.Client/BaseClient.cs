﻿using ProxmoxVEAPI.Client.Core;
using System;
using System.Net.Http;
using System.Text;
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

        protected async Task<bool> PostAsSuccessAsync(string uri, object data)
        {
            var client = GetHttpClient();
            var httpResponse = await client.PostAsync(uri, SerializeBody(data));

            return httpResponse.IsSuccessStatusCode;
        }

        protected async Task<bool> PostAsSuccessWithoutTokenAsync(string uri, object data)
        {
            var client = GetHttpClient();
            client.DefaultRequestHeaders.Clear();
            var httpResponse = await client.PostAsync(uri, SerializeBody(data));

            return httpResponse.IsSuccessStatusCode;
        }

        protected async Task<bool> DeleteAsSuccessAsync(string uri)
        {
            var client = GetHttpClient();
            var httpResponse = await client.DeleteAsync(uri);

            return httpResponse.IsSuccessStatusCode;
        }

        private HttpContent SerializeBody(object data)
        {
            return new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");
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
