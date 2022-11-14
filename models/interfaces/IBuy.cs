
using MongoDB.Bson;
using BuyingLibrary.models.interfaces;
using MongoDB.Bson.Serialization.Attributes;

namespace BuyingLibrary
{
    public interface IBuy
    {
        [BsonId]
        string Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        double Coast { get; set; }
        IItem Item { get; set; }
        int Count { get; set; }
    }
}
