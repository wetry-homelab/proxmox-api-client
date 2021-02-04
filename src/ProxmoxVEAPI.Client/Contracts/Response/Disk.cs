using System.Text.Json.Serialization;

namespace ProxmoxVEAPI.Client.Contracts.Response
{
    public class Disk
    {
        [JsonPropertyName("used")]
        public long Used { get; set; }

        [JsonPropertyName("total")]
        public long Total { get; set; }

        [JsonPropertyName("free")]
        public long Free { get; set; }

        [JsonPropertyName("avail")]
        public long Available { get; set; }
    }
}
