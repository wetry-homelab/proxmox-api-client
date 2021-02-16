using System.Threading.Tasks;

namespace ProxmoxVEAPI.Client
{
    public class QemuClient : BaseClient
    {
        private const string BaseQemuUri = "api2/json/nodes";

        public Task<bool> RestartQemu(string nodeId, int vmId)
        {
            return PostAsSuccessAsync($"{BaseQemuUri}/{nodeId}/qemu/{vmId}/status/reboot", null);
        }

        public Task<bool> DeleteQemu(string nodeId, int vmId)
        {
            return DeleteAsSuccessAsync($"{BaseQemuUri}/{nodeId}/qemu/{vmId}");
        }

        public Task<bool> StopQemu(string nodeId, int vmId)
        {
            return PostAsSuccessAsync($"{BaseQemuUri}/{nodeId}/qemu/{vmId}/status/stop", null);
        }

        public Task<bool> ShutdownQemu(string nodeId, int vmId)
        {
            return PostAsSuccessAsync($"{BaseQemuUri}/{nodeId}/qemu/{vmId}/status/shutdown", null);
        }

        public Task<bool> ResumeQemu(string nodeId, int vmId)
        {
            return PostAsSuccessAsync($"{BaseQemuUri}/{nodeId}/qemu/{vmId}/status/resume", null);
        }

        public Task<bool> StartQemu(string nodeId, int vmId)
        {
            return PostAsSuccessAsync($"{BaseQemuUri}/{nodeId}/qemu/{vmId}/status/start", null);
        }
    }
}
