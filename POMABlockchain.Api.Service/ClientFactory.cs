using System;
using Microsoft.Extensions.Configuration;
using POMABlockchain.Modules.JsonRpc.Client;

namespace POMABlockchain.Api.Service
{
    public static class ClientFactory
    {
        public static IClient GetClient(IConfiguration configuration)
        {
            var urlRPC = configuration.GetSection("NodeSettings:rpcUrl").Value;
            return new RpcClient(new Uri(urlRPC));
        }
    }
}
