using System;
using System.Linq;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace IliaStore.Models
{
    public class Customer
    {
        [BsonId]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email {get; set;}
        public IList<Order> Orders {get; set;}
    }
}
