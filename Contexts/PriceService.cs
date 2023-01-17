using BuyingLibrary.models.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingLibrary.Contexts
{
    public class PriceService : IService<Price>
    {
        public IMongoCollection<Price> collection { get; }

        public PriceService(MongoContext context) 
        {

            this.collection = context.PricesCollection;
        
        }

        public Task<Price> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Price>> GetAsync()
        {
            return collection.Find<Price>("{}").ToListAsync();
        }

        public Task<Price> GetAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Price> PostAsync(Price obj)
        {
            throw new NotImplementedException();
        }

        public Task<Price> PutAsync(Price obj)
        {
            throw new NotImplementedException();
        }
    }
}
