using POMABlockchain.Api.Model;
using POMABlockchain.Modules.JsonRpc.Client;
using POMABlockchain.Modules.RPC.Services.Block;

namespace POMABlockchain.Api.Service
{
    public class BlockService : IBlockService
    {
        private readonly IClient _client;
        private readonly IBlockRepository _blockRepository;
        public BlockService(IClient client, IBlockRepository blockRepository)
        {
            _client = client;
            _blockRepository = blockRepository;

        }
        
        public Modules.RPC.DTOs.Block GetBlockFromBlockchain(int index)
        {
            var block = new POMABlockchainGetBlock(_client);
            return block.SendRequestAsync(index).Result;
                        
        }
        public int GetActualBlockFromBlockchain()
        {
            var block = new POMABlockchainGetBlockCount(_client);
            return block.SendRequestAsync().Result;

        }
        public void Insert(Block block)
        {
            _blockRepository.Insert(block);
        }
    }
}
