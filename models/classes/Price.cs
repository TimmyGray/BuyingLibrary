using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BuyingLibrary.models.classes
{
    [BsonIgnoreExtraElements]
    public class Price
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? _id { get; set; }

        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("cost")]
        public double Cost { get; set; }

        [BsonIgnore]
        public Item? Itemofprice { get; set; }

        public override string ToString()
        {
            return $"\n\t---Price---\n{_id}\n{Name}\n{Cost}\n{Itemofprice}\n";
        }

    }
}
