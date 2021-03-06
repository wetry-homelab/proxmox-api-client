﻿using ProxmoxVEAPI.Client;
using System;
using System.Threading.Tasks;

namespace Debugger
{
    class Program
    {
        async static Task Main(string[] args)
        {
            ConfigureClient.Initialise("https://infra.ice-artefact.com", "PVEAPIToken=root@pam!monsupertoken=05449ebc-2eaf-42a6-950a-b6a341f528d0");

            //Console.WriteLine("Get nodes.");
            //var nodeClient = new NodeClient();
            //var nodes = await nodeClient.GetNodesAsync();
            //var nodeDetails = await nodeClient.GetNodeStatusAsync("Homelab");

            //Console.WriteLine("Get clusters.");
            //var clusterClient = new ClusterClient();
            //var clusterStatus = await clusterClient.GetClusterStatus();

            //Console.WriteLine("QEMU Status.");
            //var qemuClient = new QemuClient();

            //for (var i = 3000; i < 3003; i++)
            //{

            //    var qemuStopped = await qemuClient.StopQemu("Homelab", i);
            //    var qemuDeleted = await qemuClient.DeleteQemu("Homelab", i);
            //}

            var userClient = new UserClient();

        }
    }
}
