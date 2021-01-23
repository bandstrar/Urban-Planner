using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanPlanner
{
    class City
    {
        //Fields
        private string _name;
        private DateTime _dateEstablished;

        //Properties
        public string Mayor { get; set; }

        //Constructor
        public City(string name)
        {
            _name = name;
        }

        //Collection
        public List<object> cityBuildings = new List<object>();

        //Methods
        public void Establish()
        {
            _dateEstablished = DateTime.Now;
        }

        public void AddBuilding(object building)
        {
            cityBuildings.Add(building);
        }

        public void ShowCity()
        {
            Console.WriteLine(
                @$"The city of {_name}
Established {_dateEstablished}
Governed by Mayor {Mayor}
The buildings within the city are as follows:
");
        }

    }
}
