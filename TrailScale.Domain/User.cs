using System;

namespace TrailScale.Domain
{
    public class User
    {
        public User()
        {
            IsLoggedIn = false;
        }

        public string Username { get; private set;}
        public bool IsLoggedIn { get; private set;}

        public void Login()
        {
            Console.WriteLine("Login to TrailScale.");
            Console.Write("USERNAME: ");
            string username = Console.ReadLine();
            Console.Write("PASSWORD: ");
            string password = Console.ReadLine();

            AuthenticateUser(username, password);
            Username = username;
        }

        public void CreateNewExcursion()
        {
            if(IsLoggedIn)
            {
                var exc = new Excursion();
                Console.WriteLine("\n____Review Excursion____");
                Console.WriteLine($"Excursion Title: {exc.Name}");
                Console.WriteLine($"Start Location: {exc.Rendezvous.StartLocation.Latitude}°,{exc.Rendezvous.StartLocation.Longitude}°");
                Console.WriteLine($"Projected Distance to Travel: {exc.Rendezvous.TravelDistance} miles");
                Console.WriteLine($"Allotted Time for Travel: {exc.Rendezvous.TravelDuration} days");
                Console.Write("\nDoes all look correct?   [Y/n]");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please login to use this functionality");
                Console.Write("Press [enter] to continue.  ");
            }
        }


        private void AuthenticateUser(string username, string password)
        {
            //TODO: login/"authentication" logic

            IsLoggedIn = true;
            Console.WriteLine("Login successful.");
        }
    }
}
