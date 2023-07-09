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
    public interface IService<T>
    {
        IMongoCollection<T> collection { get; }

        public Task<List<T>> GetAsync();
        public Task<T> GetAsync(string id);
        public Task<T> GetAsync(string field1, string field2);
        public Task<T> PostAsync(T obj);
        public Task<T> PutAsync(T obj);
        public Task<T> DeleteAsync(string id);

    }
}
