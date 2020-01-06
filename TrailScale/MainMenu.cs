using System;
using TrailScale.Domain;

namespace TrailScale
{
    public class MainMenu
    {
        User _u;
        Splash _splash;

        public void Launch(User u)
        {
            _u = u;
            _splash = new Splash();

            string cmd;

            do
            {
                LoadMenu();
                cmd = Console.ReadLine().ToUpper();
                SectionBreak();
                switch (cmd)
                {
                    case "1":
                        _u.CreateNewExcursion();
                        break;
                    case "2":
                        _u.ReviewExcursions();
                        break;
                    case "X":
                        Environment.Exit(0);
                        break;
                    default:                        
                        Console.WriteLine("\nInvalid Command");
                        Continue();
                        break;
                }
                Console.Clear();
            } while (cmd != "X");
        }
        
        public void LoadMenu()
        {
            Console.Clear();
            Console.WriteLine(_splash.Logo);
            Console.Write("\n\nWhat would you like to do?:\n");

            Console.WriteLine("[1] Create New Excursion");
            Console.WriteLine("[2] Review Saved Excursions");
            Console.WriteLine("[X] Quit Application");
            
            Console.Write("\nKey your command: ");
        }

        private void Continue() 
        {
            Console.WriteLine("\nPress [enter] to continue...");
            Console.ReadLine();
        }

        private void SectionBreak()
        {
            Console.WriteLine($"\n{new string('+', 40)}\n");
        }
    }
}
