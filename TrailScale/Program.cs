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
            Console.Write(trip.name);
            Console.WriteLine($"And it will take you {trip.days} days");
            Console.WriteLine(trip.pace);
            Console.WriteLine("weather");
            Console.WriteLine(trip.weather.precipitation);
            Console.ReadLine();
        }
    }
}
