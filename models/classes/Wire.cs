

namespace BuyingLibrary
{
    public class Wire : IBuy
    {
        private string name;
        private string description;
        private double coast;

        public Wire(string _name, string _description, double _coast)
        {

            name = _name;
            description = _description;
            coast = _coast;

        }

        public string Id { get; set; }

        public string Name { get { return name; }}

        public string Description { get { return description; }}

        public double Coast { get { return coast; }}

        public void SetName(string _name)
        {
            name = _name;
        }

        public void SetDescription(string _description)
        {
            description = _description;
        }

        public void SetCoast(double _coast)
        {
            coast = _coast;
        }

    }
}
