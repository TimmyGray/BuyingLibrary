using BuyingLibrary.models.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingLibrary.Contexts
{

    public class PriceService : IService<BsonDocument>
    {
        public IMongoCollection<BsonDocument> collection { get; }

        public PriceService(MongoContext context) 
        {

            this.collection = context.PricesCollection;
        
        }


        public Task<BsonDocument> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BsonDocument>> GetAsync()
        {
            var documents =await collection.Find("{}").ToListAsync();
           
            return documents;
        }

        public Task<BsonDocument> GetAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<BsonDocument> PostAsync(BsonDocument obj)
        {
            throw new NotImplementedException();
        }

        public Task<BsonDocument> PutAsync(BsonDocument obj)
        {
            throw new NotImplementedException();
        }

        public Task<BsonDocument> GetAsync(string field1, string field2)
        {
            throw new NotImplementedException();
        }
    }
}
