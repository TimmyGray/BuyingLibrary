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
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonId]
        public string _id { get; set; }
        
        [BsonElement("client")]
        public Client Client { get; set; }  

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
            Status = OrderStatus.under_consideration;

        }

        public override string ToString()
        {
            return $"\n\t---Order---\n" +
                $"id:{_id}\n" +
                $"name:{Name}\n" +
                $"status:{Status}\n" +
                $"date of create:{Created}\n" +
                $"client name:{Client.Login}\n" +
                $"client email:{Client.Email}\n";
        }

    }
}
