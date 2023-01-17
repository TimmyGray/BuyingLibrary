using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingLibrary.models.classes
{
    public  class Buy
    {

        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("description")]
        public string? Description { get; set; }

        [BsonElement("cost")]
        public double Cost { get; set; }

        [BsonElement("item")]
        public string? Item { get; set; }

        [BsonElement("count")]
        public int Count { get; set; }

    }
}
