using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrailScale.Domain
{
    public class Trip
    {
        public string Name { get; }
        public Weather Weather { get; }
        public Trail Trail { get; }
        public double Pace { get; }
        public double Days { get; }


        public Trip(string tripName, Weather tripWeather, Trail tripTrail)
        {
            Name = tripName;
            Weather = tripWeather;
            Trail = tripTrail;
            Pace = CaculatePace();
            Days = CaculateDays();
        }

        protected double CaculateDays()
        {
            var hours = Trail.Length / Pace;
            var days = hours / 8;
            return days;
        }

        protected double CaculatePace()
        {
            double pace = 2.5;


            pace *= TempMultiplier(Weather);
            pace *= PrecipitationMultiplier(Weather);

            return pace;
        }

        protected double PrecipitationMultiplier(Weather tripWeather)
        {
            if (tripWeather.Precipitation == Precipitation.Rain)
                return .5;
            else if (tripWeather.Precipitation == Precipitation.Snow)
                return .75;
            else
                return 1.0;
        }

        protected double TempMultiplier(Weather tripWeather)
        {
            if (tripWeather.Temperature == Temperature.SubZero)
                return .5;
            else if (tripWeather.Temperature == Temperature.SubFreezingAboveZero)
                return 0.75;
            else if (tripWeather.Temperature == Temperature.AboveFreezingAndBelowSeventy)
                return 1.0;
            else if (tripWeather.Temperature == Temperature.AboveSeventyAndBelowNinety)
                return 0.75;
            else
                return .5;

        }


    }
}
