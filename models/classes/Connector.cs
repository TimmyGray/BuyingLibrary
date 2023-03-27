using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuyingLibrary.models.enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BuyingLibrary.models.classes
{
    public class Connector:Item
    {
        //[BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        //public string? _id { get; set; }

        //[BsonElement("name")]
        //public string? Name { get; set; }

        //[BsonElement("type")]
        //public string? Type { get; set; }

        [BsonElement("count")]
        public int? Count { get; set; }

        public override string ToString()
        {
            return $"\n\t---Connector---\n{_id}\n{Name}\n{Type}\n";
        }

    }
}
