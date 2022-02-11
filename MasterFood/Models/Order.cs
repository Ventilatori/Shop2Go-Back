﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterFood.Models
{
    public class Order
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
       // [BsonElement("Shop")]
       // public MongoDBRef Shop { get; set; }
        public List<Item> Items { get; set; }
        //public DateTime OrderTime { get; set; }
        //public DateTime CompletionTime { get; set; }
        public string Status{ get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime OrderTime { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime CompletitionTime { get; set; }

        public Order()
        {
            ID = ObjectId.GenerateNewId().ToString();
        }

    }
}
