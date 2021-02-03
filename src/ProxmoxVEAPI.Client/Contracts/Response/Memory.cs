using System.Text.Json.Serialization;

namespace ProxmoxVEAPI.Client.Contracts.Response
{
    public class Memory
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("free")]
        public int Free { get; set; }

        [JsonPropertyName("used")]
        public int Used { get; set; }
    }
}
