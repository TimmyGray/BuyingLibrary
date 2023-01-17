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
        private readonly IMongoCollection<Price> pricescollection;
        private readonly IMongoCollection<Connector> connectorscollection;
        

        public MongoContext(IOptions<Settings> settings)
        {
            Console.WriteLine($"Database connection string:{settings.Value.ConnectionStrings}");
            Console.WriteLine($"name of Database:{settings.Value.DataBase}");
            
            var client = new MongoClient(settings.Value.ConnectionStrings);
            var db = client.GetDatabase(settings.Value.DataBase);
            
            ordercollection = db.GetCollection<Order>("orders");
            buyscollection = db.GetCollection<Buy>("buys");
            pricescollection = db.GetCollection<Price>("prices");
            connectorscollection = db.GetCollection<Connector>("connectors");

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

        internal IMongoCollection<Price> PricesCollection
        {
            get
            {
                return pricescollection;
            }
        }

        internal IMongoCollection<Connector> ConnectorsCollection
        {
            get 
            { 
                return connectorscollection;
            }
        }
        
    }
}
