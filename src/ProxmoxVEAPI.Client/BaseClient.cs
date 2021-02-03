using System;
using System.Net.Http;

namespace ProxmoxVEAPI.Client
{
    public class BaseClient
    {
        public HttpClient GetHttpClient()
        {
            var client = new HttpClient()
            {
                BaseAddress = new Uri(ConfigureClient.BaseUri)
            };

            client.DefaultRequestHeaders.Remove("Authorization");
            client.DefaultRequestHeaders.Add("Authorization", ConfigureClient.AccessToken);

            return client;
        }
    }
}
