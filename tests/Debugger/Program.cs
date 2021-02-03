using ProxmoxVEAPI.Client;
using System;
using System.Threading.Tasks;

namespace Debugger
{
    class Program
    {
        async static Task Main(string[] args)
        {
            ConfigureClient.Initialise("https://infra.ice-artefact.com", "PVEAPIToken=root@pam!monsupertoken=05449ebc-2eaf-42a6-950a-b6a341f528d0");

            Console.WriteLine("Get nodes.");
            var nodeClient = new NodeClient();
            var nodes = await nodeClient.GetNodesAsync();

            Console.WriteLine("Get clusters.");
            var clusterClient = new ClusterClient();
            var clusterStatus = await clusterClient.GetClusterStatus();
        }
    }
}
