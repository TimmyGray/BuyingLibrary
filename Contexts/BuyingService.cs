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

           return await collection.Find<Buy>(b=>b.IsCustom==false).ToListAsync();

        }

        public async Task<Buy> GetAsync(string id)
        {
            return await collection.Find(b=>b._id == id).FirstOrDefaultAsync<Buy>();
        }

        public async Task<Buy> PostAsync(Buy newbuy)
        {
            //if (newbuy._id!="")
            //{
            //    return newbuy;
            //}
            await collection.InsertOneAsync(newbuy);
            return newbuy;


        }

        public async Task<Buy> PutAsync(Buy newbuy)
        {
            var filter = Builders<Buy>.Filter.Eq(o => o._id, newbuy._id);
            var update = Builders<Buy>.Update.Set(o => o, newbuy);
            var result = await collection.FindOneAndUpdateAsync(filter, update);
            return result;
        }

        public async Task<Buy> DeleteAsync(string id)
        {

            return await collection.FindOneAndDeleteAsync<Buy>(b=>b._id==id);

        }

        public Task<Buy> GetAsync(string field1, string field2)
        {
            throw new NotImplementedException();
        }
    }
}
