using POMABlockchain.Modules.JsonRpc.Client;
using POMABlockchain.Modules.RPC.DTOs;
using POMABlockchain.Modules.RPC.Services.Block;

namespace POMABlockchain.Api.Service
{
    public class BlockService
    {
        private readonly IClient _client;
        public BlockService(IClient client)
        {
            _client = client;
        }
        
        public Block GetBlockFromBlockchain(int index)
        {
            var block = new POMABlockchainGetBlock(_client);
            return block.SendRequestAsync(index).Result;
                        
        }
    }
}
