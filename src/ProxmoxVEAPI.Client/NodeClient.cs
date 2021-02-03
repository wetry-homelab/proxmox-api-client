﻿using ProxmoxVEAPI.Client.Contracts.Response;
using System.Threading.Tasks;

namespace ProxmoxVEAPI.Client
{
    public class NodeClient : BaseClient
    {
        private const string GetNodesListUri = "api2/json/nodes";

        public Task<Node[]> GetNodesAsync()
        {
            return GetAsync<Node>(GetNodesListUri);
        }
    }
}
