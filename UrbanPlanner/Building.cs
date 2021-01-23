using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanPlanner
{
    class Building
    {
        //Fields
        private string _designer;
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        //Properties
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume { get { return Width * Depth * (3 * Stories); } }
        
        //Constructor
        public Building(string address)
        {
            _address = address;
            _designer = "Rob Bandstra";
        }

        //Methods
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string purchaser)
        {
            _owner = purchaser;
        }

        public void Display()
        {
            Console.Write(
                    @$"{_address}
Designed by {_designer}
Constructed on {_dateConstructed}
Owned by {_owner}
{Volume} cubic meters of space

");
        }

    }
}
