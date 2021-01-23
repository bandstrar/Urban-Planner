using System;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            City Fantasyberg = new City("Fantasyberg")
            {
                Mayor = "J. R. R. Tolkien"
            };

            Fantasyberg.Establish();

            Building FiveOneTwoEighth = new Building("512 N 8th Ave", "Brent Weeks")
            {
                Width = 50.5,
                Depth = 60.7,
                Stories = 5,
            };

            Building SimonMed = new Building("6740 E Camelback Road", "Patrick Rothfuss")
            {
                Width = 132.8,
                Depth = 92.3,
                Stories = 1
            };

            Building Upmc = new Building("201 State St", "N. K. Jemisin")
            {
                Width = 220.1,
                Depth = 189.9,
                Stories = 12
            };

            Building LakewoodRanch = new Building("8330 Lakewood Ranch Blvd", "Brandon Sanderson")
            {
                Width = 187.7,
                Depth = 99.2,
                Stories = 3
            };

            FiveOneTwoEighth.Construct();
            SimonMed.Construct();
            Upmc.Construct();
            LakewoodRanch.Construct();

            FiveOneTwoEighth.Purchase("Nathan Gonzalez");
            SimonMed.Purchase("Jameka Echols");
            Upmc.Purchase("Dylan Griffith");
            LakewoodRanch.Purchase("Rob Bandstra");

            Fantasyberg.AddBuilding(FiveOneTwoEighth);
            Fantasyberg.AddBuilding(SimonMed);
            Fantasyberg.AddBuilding(Upmc);
            Fantasyberg.AddBuilding(LakewoodRanch);

            Fantasyberg.ShowCity();

            foreach (Building building in Fantasyberg.cityBuildings)
            {
                building.Display();
            }
        }
    }
}
