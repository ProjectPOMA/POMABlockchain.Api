



using POMABlockchain.Api.Model;

namespace POMABlockchain.Api.Service
{
    public interface IBlockService
    {
        Modules.RPC.DTOs.Block GetBlockFromBlockchain(int index);
        int GetActualBlockFromBlockchain();
        void Insert(Block block);
        Block GetByIndex(int blockIndex);
    }
}
