﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MasterFood.Models
{
    public class Shop
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Tags { get; set; }
        public string Picture { get; set; }
        [BsonElement("orderCount")]
        public int OrderCount { get; set; }
        [JsonIgnore]
        public MongoDBRef Owner { get; set; }
        public List<Item> Items { get; set; }
        [JsonIgnore]
        public List<MongoDBRef> Orders { get; set; }
    }
}
