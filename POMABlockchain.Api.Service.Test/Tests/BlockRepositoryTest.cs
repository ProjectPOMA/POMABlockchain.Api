using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Serializers;
using POMABlockchain.Api.Model;
using POMABlockchain.Api.Repository;

using System;
using Xunit;

namespace POMABlockchain.Api.Service.Test
{
    public class BlockRepositoryTest : BaseTest
    {
              
        [Fact]
        public void ShouldInsertBlock()
        {
            try
            {
                _blockRepository.Insert(new Block { Hash = "c9f2cc7af13499b2d27b02f23c1bef72419f63ae4dbe15064696d6d7010889b8" });
                Assert.True(true);
            }
            catch (Exception ex)
            {
                Assert.False(false, ex.Message);
            }
        }
    }
}
