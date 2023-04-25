global using MongoDB.Bson;
global using MongoDB.Driver;
global using MongoDB.Driver.GridFS;
using BuyingLibrary.models.classes;
using BuyingLibrary.models.interfaces;
using BuyingLibrary.AppSettings;
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
        private readonly GridFSBucket imagestore;


        public MongoContext(IOptions<DataBaseOptions> settings)
        {

            var client = new MongoClient(settings.Value.DataBaseConnection);
            var db = client.GetDatabase(settings.Value.DataBase);

            ordercollection = db.GetCollection<Order>("orders");
            buyscollection = db.GetCollection<Buy>("buys");
            pricescollection = db.GetCollection<BsonDocument>("prices");
            connectorscollection = db.GetCollection<Connector>("connectors");
            coilscollection = db.GetCollection<Coil>("coils");
            clientscollection = db.GetCollection<Client>("clients");
            imagestore = new GridFSBucket(db, new GridFSBucketOptions
            {
                BucketName = "imagestore"
            });
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

        internal IMongoCollection<Connector> ConnectorsCollection
        {
            get
            {
                return connectorscollection;
            }
        }

        internal GridFSBucket Imagestore
        {

            get
            {
                return imagestore;
            }

        }
    }
}
