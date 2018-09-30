using POMABlockchain.Api.Repository;
using Xunit;

namespace POMABlockchain.Api.Service.Test
{
    public class BlockServiceTest : BaseTest
    {
        [Fact]
        public void ShouldReturnBlockCountFromBlockchain()
        {
            var block =_blockService.GetBlockFromBlockchain(39999);
            Assert.True(block != null);
        }

    }
}
