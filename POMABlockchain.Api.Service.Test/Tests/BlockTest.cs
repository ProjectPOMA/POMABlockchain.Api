using Xunit;

namespace POMABlockchain.Api.Service.Test
{
    public class BlockTest
    {
        private readonly BlockService _blockService;
        public BlockTest()
        {
            _blockService = new BlockService(ClientFactory.GetClient(new TestSettings()));
        }

        [Fact]
        public void ShouldReturnBlockCount()
        {
            var block =_blockService.GetBlockFromBlockchain(39999);
            Assert.True(block != null);
        }


    }
}
