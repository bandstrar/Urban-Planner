using System;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEighth = new Building("512 N 8th Ave")
            {
                Width = 50.5,
                Depth = 60.7,
                Stories = 5,
            };

            Building SimonMed = new Building("6740 E Camelback Road")
            {
                Width = 132.8,
                Depth = 92.3,
                Stories = 1
            };

            Building Upmc = new Building("201 State St")
            {
                Width = 220.1,
                Depth = 189.9,
                Stories = 12
            };

            Building LakewoodRanch = new Building("8330 Lakewood Ranch Blvd")
            {
                Width = 187.7,
                Depth = 99.2,
                Stories = 3
            };

            FiveOneTwoEighth.Construct();
            SimonMed.Construct();
            Upmc.Construct();
            LakewoodRanch.Construct();

            FiveOneTwoEighth.Purchase("Brent Weeks");
            SimonMed.Purchase("Patrick Rothfuss");
            Upmc.Purchase("Brandon Sanderson");
            LakewoodRanch.Purchase("N. K. Jemisin");

            FiveOneTwoEighth.Display();
            SimonMed.Display();
            Upmc.Display();
            LakewoodRanch.Display();
        }
    }
}
