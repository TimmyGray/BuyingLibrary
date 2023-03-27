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
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonId]
        public string _id { get; set; }

        [BsonElement("client")]
        public Client client { get; set; }

        [BsonElement("client")]
        public Client client { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("created")]
        public DateTime Created { get; }

        [BsonElement("status")]
        public OrderStatus Status { get; set; }

        [BsonElement("listofbuys")]
        public List<Buy> Buys { get; set; }

    }
}
