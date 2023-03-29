using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingLibrary.models.classes
{
    [BsonIgnoreExtraElements]
    public class BuyImage
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string? _id { get; set; }

        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("type")]
        public string? Type { get; set; }

        [BsonElement("size")]
        public int Size { get; set; }

        [BsonIgnore]
        public byte[] Data { get; set; }

    }
}
