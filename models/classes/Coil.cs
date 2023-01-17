using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BuyingLibrary.models.classes
{
    public class Coil
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("type")]
        public string? Type { get; set; }

        [BsonElement("length")]
        public double Length { get; set; }
        
        [BsonElement("typeofsignal")]
        public string? typeofsignal { get; set; }

    }
}
