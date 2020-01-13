using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrailScale.Domain;


namespace TrailScale
{
    public class TripManager
    {
        public Trip CreateNewTrip()
        {
            Console.WriteLine("What would you like to name your new trip?");
            var name = Console.ReadLine();
            Console.WriteLine(@"
                Will there be:
                0 - None
                1 - Rain
                2 - Snow
");
            var consoleRain = Console.ReadLine();
            int rainInt;
            int.TryParse(consoleRain, out rainInt);

            var weather = new Weather((Precipitation)rainInt, Temperature.AboveFreezingAndBelowSeventy);
            var trail = new Trail(40, TrailDifficulty.Hard, "Hard Trail");
            Trip trip = new Trip(name, weather, trail);

            return trip;          
        }


    }
}
