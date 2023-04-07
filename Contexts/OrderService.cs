using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuyingLibrary.models.classes;
using BuyingLibrary.models.interfaces;
using MongoDB;
using MongoDB.Driver;

namespace BuyingLibrary.Contexts
{
    public class OrderService:IService<Order>
    {

        public IMongoCollection<Order> collection { get; }
        private IMongoCollection<Buy> buycollection { get; }
        private IMongoCollection<Client> clientcollection { get; }

        public OrderService(MongoContext DB)
        {
            collection = DB.OrderCollection;
            buycollection = DB.BuysCollection;
            clientcollection = DB.ClientsCollection;
        }

        public async Task<List<Order>> GetAsync()
        {
            
            return await collection.Find<Order>("{}").ToListAsync();

        }

        public async Task<List<Order>> GetAsync(string clientid)
        {
            return await collection
                .Find(o=>o.client.Name==clientid)
                .ToListAsync<Order>();
        }

        public async Task<Order> GetAsync(string clientid, string orderid)
        {

            return await collection
                .Find(o=>o.client.Name==clientid&&o._id ==orderid)
                .FirstOrDefaultAsync<Order>();

        }
        
        public async Task<Order> PostAsync(Order neworder)
        {
            Console.WriteLine("Post order service");
            //var client  =await clientcollection
            //    .Find(c=>c._id==neworder.client._id)
            //    .FirstOrDefaultAsync<Client>();
            //var client = collection
            //    .Find(o=>o.client.Name== neworder.client.Name&&o.client.Email==neworder.client.Email)
            //    .FirstOrDefault<Order>();
            //neworder.client._id = client._id;
            foreach (var buy in neworder.Buys)
            {
                if (buy._id=="")
                {
                    buy._id = ObjectId.GenerateNewId().ToString();
                    buy.Image._id= ObjectId.GenerateNewId().ToString();
                    buy.IsCustom = true;
                    Console.WriteLine($"Id for custom buy: {buy._id}");

                }
                Console.WriteLine(buy._id);
            }

            Console.WriteLine(neworder.ToString());

            await collection.InsertOneAsync(neworder);
            return neworder;


        }

        public async Task<Order> PutAsync(Order neworder)
        {
            var filter = Builders<Order>.Filter.Eq(o=>o._id,neworder._id);
            var update = Builders<Order>.Update.Set(o => o, neworder);
            var result = await collection.FindOneAndUpdateAsync(filter, update);
            return result;
        }

        public async Task<Order> DeleteAsync(string id)
        {

            return await collection.FindOneAndDeleteAsync<Order>(o=>o._id ==id);

        }

        Task<Order> IService<Order>.GetAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
