using AutoMapper;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Serializers;
using POMABlockchain.Api.Model;
using POMABlockchain.Api.Repository;

namespace POMABlockchain.Api.Service.Test
{
    public abstract class BaseTest
    {
        protected readonly SyncBlockchainService _syncBlockchainService;
        protected readonly BlockService _blockService;
        protected readonly TransactionService _transactionService;


        protected readonly BlockRepository _blockRepository;

        protected IConfiguration configuration;

        protected BaseTest()
        {
            CreateConfiguration();


            //auto mapper configuration
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            var mapper = mockMapper.CreateMapper();

            //Bson Mapper
            BsonClassMap.RegisterClassMap<Block>(cm =>
            {
                cm.AutoMap();
                cm.MapIdProperty(c => c.IdMongo)
                    .SetIdGenerator(StringObjectIdGenerator.Instance)
                    .SetSerializer(new StringSerializer(BsonType.ObjectId));
            });


            var client = ClientFactory.GetClient(configuration);

            _blockRepository = new BlockRepository(configuration);

            _blockService = new BlockService(client, _blockRepository);
            _transactionService = new TransactionService(client);
            _syncBlockchainService = new SyncBlockchainService(_blockService, mapper);

        }
        private void CreateConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("test-settings.json");
            configuration = builder.Build();
        }

    }
}
