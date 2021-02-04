using System.Text.Json.Serialization;

namespace ProxmoxVEAPI.Client.Contracts.Response
{
    public class Memory
    {
        [JsonPropertyName("total")]
        public long Total { get; set; }

        [JsonPropertyName("free")]
        public long Free { get; set; }

        [JsonPropertyName("used")]
        public long Used { get; set; }
    }
}
