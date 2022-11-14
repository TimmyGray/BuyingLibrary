using BuyingLibrary.models.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuyingLibrary.models.enums;

namespace BuyingLibrary.models.classes
{
    public class Connector:IItem
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public ConnectorType Type { get; set; }

    }
}
