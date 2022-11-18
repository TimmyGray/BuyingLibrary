using BuyingLibrary.models.enums;
using BuyingLibrary.models.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BuyingLibrary.models.classes
{
    public class Order : IOrder
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("created")]
        public DateTime Created { get; }

        [BsonElement("status")]
        public OrderStatus Status { get; set; }

        [BsonElement("listofbuys")]
        public List<Buy> Buys { get; set; }

        public Order()
        {

            Buys = new List<Buy>();
            Created = DateTime.Now;

        }

    }
}
