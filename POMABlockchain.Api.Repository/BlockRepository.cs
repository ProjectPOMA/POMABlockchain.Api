using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using POMABlockchain.Api.Model;

namespace POMABlockchain.Api.Repository
{
    public class BlockRepository : BaseMongoRepository, IBlockRepository
    {
        private IMongoDatabase _db;
        public BlockRepository(IConfiguration configuration) : base(configuration)
        {
            _db = client.GetDatabase("Block");
        }
        public Block GetByHash(string hash)
        {
            var filter = Builders<Block>.Filter.Eq("Hash", hash);

            return _db.GetCollection<Block>("Blocks")
                .Find(filter).FirstOrDefault();
        }
        public void Insert(Block entity)
        {
            var collection = _db.GetCollection<Block>("Blocks");
            collection.InsertOneAsync(entity).Wait();
        }
        public void Delete(string hash)
        {
            var collection = _db.GetCollection<Block>("Blocks");
            var filter = Builders<Block>.Filter.Eq("Hash", hash);

            collection.DeleteOne(filter);
        }
        //public void Update(string sku, Block product)
        //{
        //    var collection = _db.GetCollection<Product>("Products");
        //    var filter = Builders<Product>.Filter.Eq("Sku", sku);

        //    collection.FindOneAndReplace(filter, product);
        //}
    }
}
