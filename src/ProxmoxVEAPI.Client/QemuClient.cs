using System.Threading.Tasks;

namespace ProxmoxVEAPI.Client
{
    public class QemuClient : BaseClient
    {
        private const string BaseQemuUri = "api2/json/nodes";

        public Task<bool> RestartQemu(string nodeId, int vmId)
        {
            return PostAsSuccessAsync($"{BaseQemuUri}/{nodeId}/qemu/{vmId}/status", null);
        }

        public Task<bool> DeleteQemu(string nodeId, int vmId)
        {
            return DeleteAsSuccessAsync($"{BaseQemuUri}/{nodeId}/qemu/{vmId}");
        }
    }
}
