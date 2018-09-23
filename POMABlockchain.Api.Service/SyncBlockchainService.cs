using AutoMapper;
using POMABlockchain.Api.Model;

namespace POMABlockchain.Api.Service
{
    public class SyncBlockchainService
    {
        private readonly IBlockService _blockService;
        private readonly IMapper _mapper;
        public SyncBlockchainService(IBlockService blockService, IMapper mapper)
        {
            _blockService = blockService ?? throw new System.Exception("block Service not found!");
            _mapper = mapper ?? throw new System.Exception("mapper Service not found!");

        }
        
        public void SyncBlockchain()
        {
            var actualBlock = _blockService.GetActualBlockFromBlockchain();

            for (int i = 0; i < actualBlock; i++)
            {
                var block = _blockService.GetBlockFromBlockchain(i);
                Block blockForMongo = new Block();
                //Mapper.Map<Modules.RPC.DTOs.Block, Model.Block>(block, blockForMongo);
                _mapper.Map(block, blockForMongo);

                _blockService.Insert(blockForMongo);


            }

        }
    }
}
