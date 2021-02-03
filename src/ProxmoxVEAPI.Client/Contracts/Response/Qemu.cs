using System.Text.Json.Serialization;

namespace ProxmoxVEAPI.Client.Contracts.Response
{
    public class Qemu
    {
        [JsonPropertyName("cpus")]
        public int Cpu { get; set; }

        [JsonPropertyName("cpu")]
        public int Socket { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("netout")]
        public int NetOut { get; set; }

        [JsonPropertyName("mem")]
        public long Memory { get; set; }

        [JsonPropertyName("netin")]
        public int NetIn { get; set; }

        [JsonPropertyName("diskwrite")]
        public int DiskWrite { get; set; }

        [JsonPropertyName("maxdisk")]
        public long MaxDisk { get; set; }

        [JsonPropertyName("maxmem")]
        public long MaxMemory { get; set; }

        [JsonPropertyName("vmid")]
        public string VmId { get; set; }

        [JsonPropertyName("diskread")]
        public int DiskRead { get; set; }

        [JsonPropertyName("pid")]
        public string PId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("template")]
        public bool Template { get; set; }

        [JsonPropertyName("disk")]
        public int Disk { get; set; }

        [JsonPropertyName("uptime")]
        public int Uptime { get; set; }

        [JsonPropertyName("serial")]
        public bool Serial { get; set; }
    }
}
