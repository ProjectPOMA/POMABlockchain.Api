using AutoMapper;
using POMABlockchain.Api.Repository;

namespace POMABlockchain.Api.Service.Test
{
    public abstract class BaseTest
    {
        protected readonly SyncBlockchainService _syncBlockchainService;
        protected readonly BlockService _blockService;
        protected readonly BlockRepository _blockRepository;

        protected BaseTest()
        {
            //auto mapper configuration
            var mockMapper = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile(new MappingProfile());
                });

            var mapper = mockMapper.CreateMapper();
            

            var testSettings = new TestSettings();
            var client = ClientFactory.GetClient(testSettings);

            _blockRepository = new BlockRepository(testSettings.Configuration);
            _blockService = new BlockService(client, _blockRepository);

            _syncBlockchainService = new SyncBlockchainService(_blockService, mapper);

        }
    }
}
