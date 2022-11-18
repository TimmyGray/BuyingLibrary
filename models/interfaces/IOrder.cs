using BuyingLibrary.models.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using BuyingLibrary.models.classes;

namespace BuyingLibrary.models.interfaces
{
    public interface IOrder
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        string Id { get; set; }

        [BsonElement("name")]
        string Name { get; set; }

        [BsonElement("created")]
        DateTime Created { get; }

        [BsonElement("status")]
        public OrderStatus Status { get; set; }

        [BsonElement("listofbuys")]
        List<Buy> Buys { get; set; }

    }
}
