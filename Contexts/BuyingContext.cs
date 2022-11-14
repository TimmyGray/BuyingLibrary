global using MongoDB.Bson;
global using MongoDB.Driver;
using Microsoft.Extensions.Options;


namespace BuyingLibrary.Contexts
{
    public class BuyingContext
    {

        IMongoDatabase db;

        public BuyingContext(IOptions<Settings> settings)
        {

            var client = new MongoClient(settings.Value.ConnectionStrings);
            if (client!=null)
            {
                 db = client.GetDatabase(settings.Value.DataBase);
            }

        }


      public IMongoCollection<BsonDocument> Collection
        {
            get
            {
                return db.GetCollection<BsonDocument>("orders");
            }
        }



    }
}
