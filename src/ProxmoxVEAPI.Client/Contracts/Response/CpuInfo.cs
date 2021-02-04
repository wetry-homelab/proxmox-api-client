using System.Text.Json.Serialization;

namespace ProxmoxVEAPI.Client.Contracts.Response
{
    public class CpuInfo
    {
        [JsonPropertyName("mhz")]
        public double Mhz { get; set; }

        [JsonPropertyName("model")]
        public string Model { get; set; }

        [JsonPropertyName("hvm")]
        public bool Hvm { get; set; }

        [JsonPropertyName("cores")]
        public int Cores { get; set; }

        [JsonPropertyName("user_hz")]
        public int UserHz { get; set; }

        [JsonPropertyName("sockets")]
        public int Sockets { get; set; }

        [JsonPropertyName("flags")]
        public string Flags { get; set; }

        [JsonPropertyName("cpus")]
        public int Cpus { get; set; }
    }
}
