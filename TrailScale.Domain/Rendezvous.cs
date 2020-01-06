using System;
using System.Device.Location;

namespace TrailScale.Domain
{
    public class Rendezvous
    {
        public Rendezvous()
        {
            InitializeNewRendezvous();
        }

        public GeoCoordinate StartLocation { get; private set;}
        public double TravelDistance { get; private set;}
        public double TravelDuration { get; private set;}

        private void InitializeNewRendezvous()
        {
            //get location
            Console.WriteLine("\nLet's start with some basics about your trip: ");
            Console.WriteLine("What is the latitude + longitude of your starting location?");
            Console.Write("Latitude: ");
            double lat = double.Parse(Console.ReadLine());
            Console.Write("Longitude: ");
            double lng = double.Parse(Console.ReadLine());

            //set geocoordinate
            StartLocation = new GeoCoordinate(lat, lng);

            //get distance + duration of trip
            Console.WriteLine("\nAlright, now onto some further details:");
            Console.Write("How far do you intend to travel? [miles - decimals acceptable] ");
            TravelDistance = double.Parse(Console.ReadLine());
            Console.Write("How much time are you alloting for this trip? [days - decimals acceptable] ");
            TravelDuration = double.Parse(Console.ReadLine());
        }

        public void GetRendevousDetails()
        {
            Console.WriteLine($"Start Location: {StartLocation.Latitude}°,{StartLocation.Longitude}°");
            Console.WriteLine($"Projected Distance to Travel: {TravelDistance} miles");
            Console.WriteLine($"Allotted Time for Travel: {TravelDuration} days");
        }
    }
}
