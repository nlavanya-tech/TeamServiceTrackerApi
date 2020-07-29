using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using TeamServiceTrackerApi.Entities;

namespace TeamServiceTrackerApi.DataLayer.Context
{
   public class MongoDbContext : IMongoDbContext
    {
        //Create context of Mongo DB
        private readonly IMongoDatabase _db;

        //get mongodb connection string values options from app settings
        public MongoDbContext(IOptions<MongoDbSetting> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);
        }
        //Get All notes Collection from MongoDB
        public IMongoCollection<Teams> teams => _db.GetCollection<Teams>("teams");
        public IMongoCollection<Users> users => _db.GetCollection<Users>("users");

        ////public IMongoCollection<TEntity> GetCollection<TEntity>(string name)
        ////{


        ////   // throw new NotImplementedException();
        ////}
        //private IMongoDatabase _mongoDatabase { get; set; }
        //private MongoClient _mongoClient { get; set; }
        //private IClientSessionHandle SessionHandle { get; set; }
        //public MongoDbContext(IOptions<MongoDbSetting> configuration)
        //{
        //    _mongoClient = new MongoClient(configuration.Value.ConnectionString);
        //    _mongoDatabase = _mongoClient.GetDatabase(configuration.Value.Database);
        //}
        //public IMongoCollection<TEntity> GetCollection<TEntity>(string name)
        //{
        //    if (string.IsNullOrEmpty(name))
        //    {
        //        return null;
        //    }
        //    return _mongoDatabase.GetCollection<TEntity>(name);
        //}
    }
}
