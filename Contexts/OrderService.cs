using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuyingLibrary.models.classes;
using BuyingLibrary.models.interfaces;
using MongoDB;

namespace BuyingLibrary.Contexts
{
    public class OrderService:IService<Order>
    {

        public IMongoCollection<Order> collection { get; }
        private IMongoCollection<Buy> testcollection { get; }

        public OrderService(MongoContext DB)
        {
            collection = DB.OrderCollection;
            testcollection = DB.BuysCollection;
        }

        public async Task<List<Order>> GetAsync()
        {
            
            //Order order1= new Order();
            //order1.Name= "1";
            //order1.Status = models.enums.OrderStatus.agree;
            //Buy buy1= new WireBuy();
            //buy1.Name= "wiretestbuy1";
            //buy1.Description = "this is testbuy1";
            //buy1.Cost = 12.24;
            //buy1.Item = "wire,trs_m,trs_m,5";
            //buy1.Count= 1;
            //testcollection.InsertOne(buy1);
            //Buy buy2 = new WireBuy();
            //buy2.Name = "wiretestbuy2";
            //buy2.Description = "this is testbuy2";
            //buy2.Cost = 9.24;
            //buy2.Item = "wire,trs_m,trs_m,3";
            //buy2.Count = 1;
            //testcollection.InsertOne(buy2);
            //Buy buy3 = new WireBuy();
            //buy3.Name = "wiretestbuy3";
            //buy3.Description = "this is testbuy3";
            //buy3.Cost = 32;
            //buy3.Item = "wire,bnc,bnc,25";
            //buy3.Count = 2;
            //testcollection.InsertOne(buy3);
            //List<Buy> list =  await testcollection.Find<Buy>("{}").ToListAsync();
            //order1.Buys= list;
            //await collection.InsertOneAsync(order1);
            return await collection.Find<Order>("{}").ToListAsync();

        }

        public async Task<Order> GetAsync(string id)
        {
            return await collection.Find<Order>(o=>o.Id==id).FirstOrDefaultAsync();
        }
        
        public async Task<Order> PostAsync(Order neworder)
        {
            Order order = new Order
            {
                Name = neworder.Name,
                client = neworder.client,
                Buys = neworder.Buys
            };

            await collection.InsertOneAsync(order);
            return order;


        }

        public async Task<Order> PutAsync(Order neworder)
        {
            var filter = Builders<Order>.Filter.Eq(o=>o.Id,neworder.Id);
            var update = Builders<Order>.Update.Set(o => o, neworder);
            var result = await collection.FindOneAndUpdateAsync(filter, update);
            return result;
        }

        public async Task<Order> DeleteAsync(string id)
        {

            return await collection.FindOneAndDeleteAsync<Order>(o=>o.Id==id);

        }



    }
}
