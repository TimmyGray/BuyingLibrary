using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingLibrary.Contexts
{
    internal class TestContext
    {

        string Id="1";
        
        private string SetId()
        {   
            Id = $"{Id}{1}";
            return Id;
        }

        private List<IBuy> ListOfBuyes;

        public TestContext()
        {

            ListOfBuyes = new List<IBuy>();
            IBuy buy1 = new Wire("testwire1", "simple test decription 1", 12.2);
            buy1.Id = SetId();
            IBuy buy2 = new Wire("testwire2", "simple test description 2", 13.3);
            buy2.Id = SetId();
            IBuy buy3 = new Wire("testwire3", "simple test description 3", 6.6);
            buy3.Id = SetId();
            ListOfBuyes.Add(buy1);
            ListOfBuyes.Add(buy2);
            ListOfBuyes.Add(buy3);

        }

        public List<IBuy> GetData()
        {
            return ListOfBuyes;
        }

        public IBuy GetOne(string id)
        {
           var buy = from b in ListOfBuyes
                      where b.Id == id
                      select b;

            return buy.FirstOrDefault();
        }

        public IBuy PostData(IBuy buy)
        {

            IBuy newbuy = buy;
            newbuy.Id = SetId();
            ListOfBuyes.Add(newbuy);
            return newbuy;

        }

        public IBuy DeleteData(string id)
        {

            var buy = from b in ListOfBuyes
                            where b.Id == id
                            select b;
            IBuy deletebuy = buy.FirstOrDefault();
            ListOfBuyes.Remove(deletebuy);
            return deletebuy;

        }

    }
}
