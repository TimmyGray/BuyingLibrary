using BuyingLibrary.models.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingLibrary.models.classes
{
    internal class Buy : IBuy
    {
        public string Id { get; set; }

        public string Name {get; set; }

        public string Description { get; set; }

        public double Coast {get; set; }

        public IItem Item { get; set; }
        
        public int Count { get; set; }
    }
}
