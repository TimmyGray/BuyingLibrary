using BuyingLibrary.models.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingLibrary.Contexts
{
    public class CoilService : IService<Coil>
    {
        public IMongoCollection<Coil> collection { get; }

        public CoilService(MongoContext context)
        {

            collection = context.CoilsCollection;

        }

        public Task<Coil> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Coil>> GetAsync()
        {
            return collection.Find<Coil>("{}").ToListAsync();
        }

        public Task<Coil> GetAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Coil> PostAsync(Coil obj)
        {
            throw new NotImplementedException();
        }

        public Task<Coil> PutAsync(Coil obj)
        {
            throw new NotImplementedException();
        }

        public Task<Coil> GetAsync(string field1, string field2)
        {
            throw new NotImplementedException();
        }
    }
}
