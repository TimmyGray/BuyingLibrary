using BuyingLibrary.models.classes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingLibrary.Contexts
{
    public class ClientService : IService<Client>
    {
        public IMongoCollection<Client> collection { get; }
        public ClientService(MongoContext db) 
        {

            collection = db.ClientsCollection;
        
        }  

        public Task<Client> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Client>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Client> GetAsync(string id)
        {
            return await collection.Find(c=>c._id==id).FirstOrDefaultAsync<Client>();
        }

        public async Task<Client> PostAsync(Client obj)
        {

            await collection.InsertOneAsync(obj);
            return obj;
        }

        public async Task<Client> PutAsync(Client obj)
        {
            var filter = Builders<Client>.Filter.Eq(c=>c._id,obj._id);
            var update = Builders<Client>.Update.Set(c => c, obj);
            var result = await collection.FindOneAndUpdateAsync(filter, update);
            return result;
        }
    }
}
