using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrailScale
{
    class Program
    {
        static void Main(string[] args)
        {
            var tripManager = new TripManager();
           var trip = tripManager.CreateNewTrip();
            Console.WriteLine("your trip is called");
            Console.Write(trip.Name);
            Console.WriteLine($"And it will take you {trip.Days} days");
            Console.WriteLine(trip.Pace);
            Console.WriteLine("weather");
            Console.WriteLine(trip.Weather.Precipitation);
            Console.ReadLine();
        }
    }
}
