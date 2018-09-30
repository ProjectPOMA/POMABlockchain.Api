using Microsoft.AspNetCore.Mvc;
using POMABlockchain.Api.Model;
using POMABlockchain.Api.Service;

namespace POMABlockchain.Api.WebApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BlockController : ControllerBase
    {
        private readonly IBlockService _blockService;
        public BlockController(IBlockService blockService)
        {
            _blockService = blockService ?? throw new System.Exception("block service not avaiable!");
        }

        [HttpGet]
        public ActionResult<Block> Get(int blockIndex)
        {
            return _blockService.GetByIndex(blockIndex);
        }
    }
}
