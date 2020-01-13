using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrailScale.Domain;


namespace TrailScale
{
    class WeatherManager
    {
        public Temperature TransformTemp(int degrees)
        {
            if (degrees < 0)
                return Temperature.SubZero;
            else if (degrees < 32)
                return Temperature.SubFreezingAboveZero;
            else if (degrees < 70)
                return Temperature.AboveFreezingAndBelowSeventy;
            else if (degrees < 90)
                return Temperature.AboveSeventyAndBelowNinety;
            else
                return Temperature.AboveNinety;
        }

        public Temperature TempRequest()
        {
            Console.Clear();
            Console.WriteLine("What will the average temperature be?");
            var consoleTemp = Console.ReadLine();
            int temp;
            if (!int.TryParse(consoleTemp, out temp))
                Console.WriteLine("The temperature must be a whole number.");

        }
    }
}
