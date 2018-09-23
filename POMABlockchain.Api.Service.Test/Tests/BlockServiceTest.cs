using POMABlockchain.Api.Repository;
using Xunit;

namespace POMABlockchain.Api.Service.Test
{
    public class BlockServiceTest
    {
        private readonly BlockService _blockService;
        private readonly BlockRepository _blockRepository;
        public BlockServiceTest()
        {
            var testSettings = new TestSettings();
            var client = ClientFactory.GetClient(testSettings);

            _blockRepository = new BlockRepository(testSettings.Configuration);
            _blockService = new BlockService(client, _blockRepository);
        }

        [Fact]
        public void ShouldReturnBlockCountFromBlockchain()
        {
            var block =_blockService.GetBlockFromBlockchain(39999);
            Assert.True(block != null);
        }



    }
}
