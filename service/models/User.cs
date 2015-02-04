using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Rutha.Models
{
    public class User
    {
      public ObjectId Id { get; set; }      
      
      public string Email { get; set; }
      
      public string Password { get; set; }
            
      public DateTime Created { get; set; }
      
      public DateTime Updated { get; set; }      
    }
}