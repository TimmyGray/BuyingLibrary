using BuyingLibrary.models.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingLibrary.Contexts
{
    public class ConnectorService : IService<Connector>
    {
        public IMongoCollection<Connector> collection { get; }

        public ConnectorService(MongoContext context) 
        {
            collection = context.ConnectorsCollection;
        }

        public Task<Connector> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Connector>> GetAsync()
        {
            return collection.Find<Connector>("{}").ToListAsync();
        }

        public Task<Connector> GetAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Connector> PostAsync(Connector obj)
        {
            throw new NotImplementedException();
        }

        public Task<Connector> PutAsync(Connector obj)
        {
            throw new NotImplementedException();
        }
    }
}
