using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingLibrary.models.classes
{
    public abstract class Item
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public abstract string? Id { get; set; }

        [BsonElement("name")]
        public abstract string? Name { get; set; }


    }
}
