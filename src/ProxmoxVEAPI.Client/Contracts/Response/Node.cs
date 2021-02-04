using System.Text.Json.Serialization;

namespace ProxmoxVEAPI.Client.Contracts.Response
{
    public class Node
    {
        [JsonPropertyName("maxdisk")]
        public long MaxDisk { get; set; }

        [JsonPropertyName("ssl_fingerprint")]
        public string SslFingerprint { get; set; }

        [JsonPropertyName("disk")]
        public long Disk { get; set; }

        [JsonPropertyName("level")]
        public string Level { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("mem")]
        public long Memory { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("uptime")]
        public int Uptime { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("maxcpu")]
        public int MaxCpu { get; set; }

        [JsonPropertyName("node")]
        public string NodeName { get; set; }

        [JsonPropertyName("cpu")]
        public int Cpu { get; set; }

        [JsonPropertyName("maxmem")]
        public long MaxMemory { get; set; }
    }
}
