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
        public override string? Id { get; set; }
        public override string Name { get; set; }
        [BsonElement("type")]
        public ConnectorType Type { get; set; }

    }
}
