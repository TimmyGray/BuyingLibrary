using BuyingLibrary.models.enums;
using BuyingLibrary.models.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingLibrary.models.classes
{
    public class Order : IOrder
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public DateTime Created { get; set; }

        public OrderStatus Status { get; set; }

        public List<IBuy> Buys { get; set; }

        public Order()
        {

            Buys = new List<IBuy>();
            Created = DateTime.Now;

        }

    }
}
