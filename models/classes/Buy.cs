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
        [BsonId]
        public string? _id { get; set; }

        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("description")]
        public string? Description { get; set; }

        [BsonElement("cost")]
        public double Cost { get; set; }

        [BsonElement("item")]
        public string? Item { get; set; }

        [BsonElement("itemid")]
        public string? ItemId { get; set; }

        [BsonElement("count")]
        public int Count { get; set; }

        public override string ToString()
        {
            return $"\n\t-----Buy-----\nname - {Name}\ndescription - {Description}\ncost - {Cost}\nitem - {Item}\n";
        }

    }
}
