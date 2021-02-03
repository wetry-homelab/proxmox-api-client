using ProxmoxVEAPI.Client.Contracts.Response;
using System.Threading.Tasks;

namespace ProxmoxVEAPI.Client
{
    public class ClusterClient : BaseClient
    {
        private const string GetClusterStatusUri = "api2/json/cluster/status";

        public Task<ClusterStatus[]> GetClusterStatus()
        {
            return GetAsync<ClusterStatus>(GetClusterStatusUri);
        }
    }
}
