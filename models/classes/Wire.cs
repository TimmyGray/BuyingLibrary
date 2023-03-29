using MongoDB.Bson;
using BuyingLibrary.models.classes;
using BuyingLibrary.models.enums;
using MongoDB.Bson.Serialization.Attributes;

namespace BuyingLibrary
{
    public class Wire
    {
        
        public string? _id { get; set; }

        [BsonElement("name")]
        public string? Name { get; set; }
        
        [BsonElement("length")]
        public double? Length { get; set; }

        [BsonElement("firstconn")]
        public Connector[]? Firstconnector { get; set; }

        [BsonElement("secondconn")]
        public Connector[]? Secondconnector { get; set; }

        [BsonElement("numberofconnectors")]
        public int? NumberOfConnectors { get; set; }

        
    }
}
