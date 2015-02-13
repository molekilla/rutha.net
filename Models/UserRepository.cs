using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using Rutha.Shared;

namespace Rutha.Models
{
    public class UserRepository : IUserRepository
    {
      IMongoDatabase database;
      public UserRepository() {
        var config = Rutha.Shared.ConfigManager.Create();
        var mongoDbConnectionString = config.Get("mongodb.connectionString");
        var client = new MongoClient("mongodb://localhost:27017");
        database = client.GetDatabase("rutha");
      }
      
      readonly List<User> _items = new List<User>();

      public async void Add(User item)
      {
        var collection = database.GetCollection<User>("users");

        await collection.InsertOneAsync(item);
      }
    }
} 