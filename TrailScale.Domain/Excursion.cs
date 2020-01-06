using System;

namespace TrailScale.Domain
{
    public class Excursion
    {

        public Excursion()
        {
            Name = NameExcursion();
            Rendezvous = new Rendezvous();
            //TODO: userID + Equipment
        }

        public string Name { get; private set;}
        public Rendezvous Rendezvous { get; private set;}

        public void GetExcursionDetails()
        {
            Console.WriteLine("\n__Excursion Details__");
            Console.WriteLine($"Excursion Title: {Name}");
            Rendezvous.GetRendevousDetails();
        }

        private string NameExcursion()
        {
            Console.Write("What would you like to title this excursion?  ");
            var excName = Console.ReadLine();
            return excName;
        }
    }
}
