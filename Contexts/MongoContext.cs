global using MongoDB.Bson;
global using MongoDB.Driver;
using BuyingLibrary.models.classes;
using BuyingLibrary.models.interfaces;
using Microsoft.Extensions.Options;


namespace BuyingLibrary.Contexts
{
    public class MongoContext
    {
        private readonly IMongoCollection<Order> ordercollection;
        private readonly IMongoCollection<Buy> buyscollection;
        

        public MongoContext(IOptions<Settings> settings)
        {
            Console.WriteLine($"Database connection string:{settings.Value.ConnectionStrings}");
            Console.WriteLine($"name of Database:{settings.Value.DataBase}");
            
            var client = new MongoClient("mongodb://127.0.0.1:12908");
            var db = client.GetDatabase(settings.Value.DataBase);
            
            ordercollection = db.GetCollection<Order>("orders");
            buyscollection = db.GetCollection<Buy>("buys");

        }

        internal IMongoCollection<Order> OrderCollection
        {
            get
            {
                return ordercollection;
            }
        }

        internal IMongoCollection<Buy> BuysCollection
        {
            get
            {
                return buyscollection;
            }
        }


        
    }
}
