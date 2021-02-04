using System.Text.Json.Serialization;

namespace ProxmoxVEAPI.Client.Contracts.Response
{
    public class NodeStatus
    {
        [JsonPropertyName("pveversion")]
        public string PveVersion { get; set; }

        [JsonPropertyName("idle")]
        public int Idle { get; set; }

        [JsonPropertyName("kversion")]
        public string KernelVersion { get; set; }

        [JsonPropertyName("uptime")]
        public long Uptime { get; set; }

        [JsonPropertyName("cpuinfo")]
        public CpuInfo CpuInfo { get; set; }

        [JsonPropertyName("memory")]
        public Memory Memory { get; set; }

        [JsonPropertyName("swap")]
        public Memory Swap { get; set; }

        [JsonPropertyName("rootfs")]
        public Disk RootFs { get; set; }
    }
}
