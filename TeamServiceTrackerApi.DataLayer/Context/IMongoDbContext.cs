using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using TeamServiceTrackerApi.Entities;

namespace TeamServiceTrackerApi.DataLayer.Context
{
  public interface IMongoDbContext
    {
        IMongoCollection<Teams> teams { get;}
        IMongoCollection<Users> users { get; }
    }
}
