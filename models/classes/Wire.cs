

using BuyingLibrary.models.classes;
using BuyingLibrary.models.enums;
using BuyingLibrary.models.interfaces;

namespace BuyingLibrary
{
    public class Wire : IItem
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public Connector firstconnector { get; set; }
        public Connector secondconnector { get; set; }

        
    }
}
