using BuyingLibrary.models.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BuyingLibrary.models.interfaces
{
    internal interface IOrder
    {
        [BsonId]
        string Id { get; set; }

        string Name { get; set; }

        DateTime Created { get; set; }

        public OrderStatus Status { get; set; }
        
        List<IBuy> Buys { get; set; }

    }
}
