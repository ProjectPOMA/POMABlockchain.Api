using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using POMABlockchain.Api.Model;
using POMABlockchain.Api.Service;
using System.Collections.Generic;

namespace POMABlockchain.Api.WebApp.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BlockController : ControllerBase
    {
        private readonly IBlockService _blockService;
        private readonly IMapper _mapper;
        public BlockController(IBlockService blockService, IMapper mapper)
        {
            _blockService = blockService ?? throw new System.Exception("block service not avaiable!");
            _mapper = mapper ?? throw new System.Exception("mapper service not avaiable!");
        }

        [HttpGet]
        [HttpGet("{blockIndex}")]
        public ActionResult<Block> Get(int blockIndex)
        {
            var block = _blockService.GetByIndex(blockIndex);
            Block blockForMongo = new Block();
            _mapper.Map(block, blockForMongo);
            return blockForMongo;
        }
  
    }
}
