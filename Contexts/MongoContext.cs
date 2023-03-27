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
        private readonly IMongoCollection<BsonDocument> pricescollection;
        private readonly IMongoCollection<Connector> connectorscollection;
        private readonly IMongoCollection<Coil> coilscollection;
        private readonly IMongoCollection<Client> clientscollection;
        

        public MongoContext(IOptions<Settings> settings)
        {
            Console.WriteLine($"Database connection string:{settings.Value.ConnectionStrings}");
            Console.WriteLine($"name of Database:{settings.Value.DataBase}");
            
            var client = new MongoClient(settings.Value.ConnectionStrings);
            var db = client.GetDatabase(settings.Value.DataBase);
            
            ordercollection = db.GetCollection<Order>("orders");
            buyscollection = db.GetCollection<Buy>("buys");
            pricescollection = db.GetCollection<BsonDocument>("prices");
            connectorscollection = db.GetCollection<Connector>("connectors");
            coilscollection = db.GetCollection<Coil>("coils");
            clientscollection = db.GetCollection<Client>("clients");
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

        internal IMongoCollection<BsonDocument> PricesCollection
        {
            get
            {
                return pricescollection;
            }
        }
<<<<<<< HEAD
=======

        internal IMongoCollection<Connector> ConnectorsCollection
        {
            get 
            { 
                return connectorscollection;
            }
        }

        internal IMongoCollection<Coil> CoilsCollection
        {
            get
            {
                return coilscollection;
            }
        }

        internal IMongoCollection<Client> ClientsCollection
        {

            get
            {
                return clientscollection;
            }

        }
>>>>>>> connector-service-checking

        internal IMongoCollection<Connector> ConnectorsCollection
        {
            get 
            { 
                return connectorscollection;
            }
        }
        
    }
}
