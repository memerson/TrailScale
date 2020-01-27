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

        private double CaculateDays()
        {
            var hours = Trail.Length / Pace;
            var days = Math.Round((hours / 8),1);
            return days;
        }

        private double CaculatePace()
        {
            //TODO: Grab user's default pace from profile
            double pace = 2.5;


            pace *= TempMultiplier(Weather);
            pace *= PrecipitationMultiplier(Weather);
            pace *= DifficultyMultiplier(Trail);

            return pace;
        }

        private double PrecipitationMultiplier(Weather tripWeather)
        {
            if (tripWeather.Precipitation == Precipitation.Rain)
                return .5;
            else if (tripWeather.Precipitation == Precipitation.Snow)
                return .75;
            else
                return 1.0;
        }

        private double TempMultiplier(Weather tripWeather)
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

        private double DifficultyMultiplier(Trail triptrail)
        {
            if (triptrail.Difficulty == TrailDifficulty.Easy)
                return 1.25;
            else if (triptrail.Difficulty == TrailDifficulty.Medium)
                return 1;
            else
                return .75;
        }


    }
}
