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
<<<<<<< HEAD
        private readonly IMongoCollection<Price> pricescollection;
        private readonly IMongoCollection<Connector> connectorscollection;
=======
        private readonly IMongoCollection<BsonDocument> pricescollection;
        private readonly IMongoCollection<Connector> connectorscollection;
        private readonly IMongoCollection<Coil> coilscollection;
        private readonly IMongoCollection<Client> clientscollection;
>>>>>>> connector-service-checking
        

        public MongoContext(IOptions<Settings> settings)
        {
            Console.WriteLine($"Database connection string:{settings.Value.ConnectionStrings}");
            Console.WriteLine($"name of Database:{settings.Value.DataBase}");
            
            var client = new MongoClient(settings.Value.ConnectionStrings);
            var db = client.GetDatabase(settings.Value.DataBase);
            
            ordercollection = db.GetCollection<Order>("orders");
            buyscollection = db.GetCollection<Buy>("buys");
<<<<<<< HEAD
            pricescollection = db.GetCollection<Price>("prices");
            connectorscollection = db.GetCollection<Connector>("connectors");

=======
            pricescollection = db.GetCollection<BsonDocument>("prices");
            connectorscollection = db.GetCollection<Connector>("connectors");
            coilscollection = db.GetCollection<Coil>("coils");
            clientscollection = db.GetCollection<Client>("clients");
>>>>>>> connector-service-checking
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

<<<<<<< HEAD
        internal IMongoCollection<Price> PricesCollection
=======
        internal IMongoCollection<BsonDocument> PricesCollection
>>>>>>> connector-service-checking
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
