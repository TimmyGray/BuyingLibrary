using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingLibrary.models.classes
{
    public class Item
    {
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonId]
        public string? _id { get; set; }

        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("type")]
        public string? Type { get; set; }


    }
}
