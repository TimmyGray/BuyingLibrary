using MongoDB.Bson;
using BuyingLibrary.models.classes;
using BuyingLibrary.models.enums;
using MongoDB.Bson.Serialization.Attributes;

namespace BuyingLibrary
{
    public class Wire : Item
    {
        
        public override string? Id { get; set; }

        public override string? Name { get; set; }
        
        [BsonElement("length")]
        public double Length { get; set; }

        [BsonElement("firstconn")]
        public Connector? firstconnector { get; set; }

        [BsonElement("secondconn")]
        public Connector? secondconnector { get; set; }

        
    }
}
