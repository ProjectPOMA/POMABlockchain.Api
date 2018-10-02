using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;

namespace POMABlockchain.Api.Repository
{
    public abstract class BaseMongoRepository
    {
        private IConfiguration _configuration;

        protected IMongoClient client;

        public BaseMongoRepository(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException("DBConfiguration is null!");


            client = new MongoClient(
        _configuration.GetSection("ConnectionString").GetSection("POMAApiConnection").Value);


        }

    }
}
