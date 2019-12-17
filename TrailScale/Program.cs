using System;
using TrailScale.Domain;

namespace TrailScale
{
    class Program
    {
        static void Main(string[] args)
        {
            User _user;
            MainMenu _mm;

            try
            {
                _user = new User();

                while(!_user.IsLoggedIn)
                {
                    _user.Login();
                }

                _mm = new MainMenu(); 
                _mm.Launch(_user);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
