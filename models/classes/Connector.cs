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

        [BsonElement("count")]
        public int? Count { get; set; }

        public override string ToString()
        {
            return $"\n\t---Connector---\n{_id}\n{Name}\n{Type}\n";
        }

    }
}
