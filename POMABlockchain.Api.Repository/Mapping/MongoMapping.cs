using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Serializers;
using POMABlockchain.Api.Model;

namespace POMABlockchain.Api.Repository
{
    public static class MongoMapping
    {
        public static IServiceCollection AddMongoMapping(this IServiceCollection services)
        {
            BsonClassMap.RegisterClassMap<Block>(cm =>
            {
                cm.AutoMap();
                cm.MapIdProperty(c => c.IdMongo)
                    .SetIdGenerator(StringObjectIdGenerator.Instance)
                    .SetSerializer(new StringSerializer(BsonType.ObjectId));
            });

            return services;
        }
    }
}

