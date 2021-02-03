using ProxmoxVEAPI.Client.Contracts.Response;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProxmoxVEAPI.Client
{
    public class NodeClient : BaseClient
    {
        public async Task<Node[]> GetNodesAsync()
        {
            var client = GetHttpClient();

            var httpResponse = await client.GetAsync("api2/json/nodes");
            httpResponse.EnsureSuccessStatusCode();

            return JsonSerializer.Deserialize<Node[]>(await httpResponse.Content.ReadAsStringAsync());
        }
    }
}
