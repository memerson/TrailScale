using System;
using System.Collections.Generic;

namespace TrailScale.Domain
{
    public class User
    {
        public User()
        {
            IsLoggedIn = false;
            SavedExcursions = new List<Excursion>();
        }

        public string Username { get; private set;}
        public bool IsLoggedIn { get; private set;}
        public List<Excursion> SavedExcursions { get; private set;}

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
                exc.GetExcursionDetails();
                Console.Write("\nDoes all look correct? [Y/N]:  ");
                Console.ReadLine();

                SavedExcursions.Add(exc);
                Console.Write($"\n{exc.Name} has been saved to your excursions.\nKey [enter] to continue...");
                Console.ReadLine();
            }
            else
                PleaseLogin();
        }

        public void ReviewExcursions()
        {
            if(IsLoggedIn)
            {
                string cmd = String.Empty;

                if (SavedExcursions.Count > 0)
                {
                    while (cmd != "X")
                    {
                        Console.Clear();
                        Console.WriteLine("\n>>>>> Review Excursions <<<<<");
                        var li = "[{0}] {1}";

                        for (int i = 0; i < SavedExcursions.Count; i++)
                        {
                            Console.WriteLine(String.Format(li, i + 1, SavedExcursions[i].Name));
                        }
                        Console.WriteLine(String.Format(li, "X", "Return to Main Menu"));
                        Console.Write("\nKey your command:  ");
                        cmd = Console.ReadLine().ToUpper();

                        if(cmd != "X")
                            SelectSavedExcursion(cmd);
                    }
                }
                else
                    Continue("No Saved Excursions available.");
            }
            else
                PleaseLogin();
        }

        private void AuthenticateUser(string username, string password)
        {
            //TODO: login/"authentication" logic

            IsLoggedIn = true;
            Console.WriteLine("Login successful.");
        }

        private void SelectSavedExcursion(string cmd)
        {
            int excIdx;

            bool isInt = Int32.TryParse(cmd, out int excLi);
            excIdx = --excLi;

            if (isInt && excIdx < SavedExcursions.Count)
            {
                SavedExcursions[excIdx].GetExcursionDetails();
                Continue();
            }
            else 
                Continue("Unaccepted command.");
        }

        #region Prompts
        private void PleaseLogin()
        {
            Continue("Please login to use this functionality");
        }

        private void Continue(string msg = "")
        {
            Console.WriteLine(msg);
            Console.Write("Press [enter] to continue...");
            Console.ReadLine();
        }
        #endregion
    }
}
