using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BuyingLibrary.models.classes
{
    public class Coil:Item
    {

        [BsonElement("length")]
        public double Length { get; set; }
        
        [BsonElement("typeofsignal")]
        public string? typeofsignal { get; set; }

        public override string ToString()
        {
            return $"\n\t---Coil---\n{_id}\n{Name}\n{Type}\n{Length}\n{typeofsignal}\n";
        }

    }
}
