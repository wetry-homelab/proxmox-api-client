using System.Text.Json.Serialization;

namespace ProxmoxVEAPI.Client.Contracts.Response
{
    public class QemuStatus
    {
        [JsonPropertyName("qmpstatus")]
        public string QmpStatus { get; set; }

        [JsonPropertyName("uptime")]
        public int Uptime { get; set; }

        [JsonPropertyName("cpu")]
        public double CpuUsage { get; set; }

        [JsonPropertyName("netout")]
        public int NetOut { get; set; }

        [JsonPropertyName("mem")]
        public long Memory { get; set; }

        [JsonPropertyName("netin")]
        public int NetIn { get; set; }

        [JsonPropertyName("maxdisk")]
        public long MaxDisk { get; set; }

        [JsonPropertyName("maxmem")]
        public long MaxMemory { get; set; }
    }
}
