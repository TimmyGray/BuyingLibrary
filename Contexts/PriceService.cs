using BuyingLibrary.models.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingLibrary.Contexts
{
<<<<<<< HEAD
    public class PriceService : IService<Price>
    {
        public IMongoCollection<Price> collection { get; }
=======
    public class PriceService : IService<BsonDocument>
    {
        public IMongoCollection<BsonDocument> collection { get; }
>>>>>>> connector-service-checking

        public PriceService(MongoContext context) 
        {

            this.collection = context.PricesCollection;
        
        }

<<<<<<< HEAD
        public Task<Price> DeleteAsync(string id)
=======
        public Task<BsonDocument> DeleteAsync(string id)
>>>>>>> connector-service-checking
        {
            throw new NotImplementedException();
        }

<<<<<<< HEAD
        public Task<List<Price>> GetAsync()
        {
            return collection.Find<Price>("{}").ToListAsync();
        }

        public Task<Price> GetAsync(string id)
=======
        public async Task<List<BsonDocument>> GetAsync()
        {
            var documents =await collection.Find("{}").ToListAsync();
           
            return documents;
        }

        public Task<BsonDocument> GetAsync(string id)
>>>>>>> connector-service-checking
        {
            throw new NotImplementedException();
        }

<<<<<<< HEAD
        public Task<Price> PostAsync(Price obj)
=======
        public Task<BsonDocument> PostAsync(BsonDocument obj)
>>>>>>> connector-service-checking
        {
            throw new NotImplementedException();
        }

<<<<<<< HEAD
        public Task<Price> PutAsync(Price obj)
=======
        public Task<BsonDocument> PutAsync(BsonDocument obj)
>>>>>>> connector-service-checking
        {
            throw new NotImplementedException();
        }
    }
}
