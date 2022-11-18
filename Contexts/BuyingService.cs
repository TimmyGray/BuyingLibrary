using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuyingLibrary.models.classes;
using MongoDB;
using MongoDB.Driver;

namespace BuyingLibrary.Contexts
{
    public class BuyingService : IService<Buy>
    {
        public IMongoCollection<Buy> collection { get; }


        public BuyingService(MongoContext DB)
        {
            collection = DB.BuysCollection;
        }

        public async Task<List<Buy>> GetAsync()
        {

            return await collection.Find<Buy>("{}").ToListAsync();

        }

        public async Task<Buy> GetAsync(string id)
        {
            var filter = Builders<Buy>.Filter.Eq(o => o.Id, id);
            return await collection.Find<Buy>(filter).FirstAsync();
        }

        public async Task<Buy> PostAsync(Buy newbuy)
        {

            await collection.InsertOneAsync(newbuy);
            return newbuy;


        }

        public async Task<Buy> PutAsync(Buy newbuy)
        {
            var filter = Builders<Buy>.Filter.Eq(o => o.Id, newbuy.Id);
            var update = Builders<Buy>.Update.Set(o => o, newbuy);
            var result = await collection.FindOneAndUpdateAsync(filter, update);
            return result;
        }

        public async Task<Buy> DeleteAsync(string id)
        {

            var filter = Builders<Buy>.Filter.Eq(o => o.Id, id);
            var result = await collection.FindOneAndDeleteAsync<Buy>(filter);
            return result;

        }
    }
}
