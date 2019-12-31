using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrailScale.Domain
{
    public class Trip
    {
        public string name { get; }
        public Weather weather { get; }
        public Trail trail { get; }
        public double pace { get; }
        public double days { get; }


        public Trip(string tripName, Weather tripWeather, Trail tripTrail)
        {
            name = tripName;
            weather = tripWeather;
            trail = tripTrail;
            pace = CaculatePace();
            days = CaculateDays();
        }

        protected double CaculateDays()
        {
            var hours = trail.length / pace;
            var days = hours / 8;
            return days;
        }

        protected double CaculatePace()
        {
            double pace = 2.5;


            pace *= TempMultiplier(weather);
            pace *= PrecipitationMultiplier(weather);

            return pace;
        }

        protected double PrecipitationMultiplier(Weather tripWeather)
        {
            if (tripWeather.precipitation == Precipitation.Rain)
                return .5;
            else if (tripWeather.precipitation == Precipitation.Snow)
                return .75;
            else
                return 1.0;
        }

        protected double TempMultiplier(Weather tripWeather)
        {
            if (tripWeather.temperature == Temperature.SubZero)
                return .5;
            else if (tripWeather.temperature == Temperature.SubFreezingAboveZero)
                return 0.75;
            else if (tripWeather.temperature == Temperature.AboveFreezingAndBelowSeventy)
                return 1.0;
            else if (tripWeather.temperature == Temperature.AboveSeventyAndBelowNinety)
                return 0.75;
            else
                return .5;

        }


    }
}
