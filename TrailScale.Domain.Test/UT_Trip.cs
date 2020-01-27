using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrailScale.Domain;

namespace TrailScale.Domain.Test
{
    [TestClass]
    public class UT_Trip
     {
        #region Properties

        #endregion

        #region trail
        [TestMethod]
        public void ShouldCaculateCorrectNumberOfDaysEasyTrail()
        {
            var trail = GivenATrailObj(10, TrailDifficulty.Easy);
            var weather = GivenAWeatherObj(Precipitation.None, Temperature.AboveFreezingAndBelowSeventy);
            var trip = WhenATripIsCreated(weather, trail);
            ThenVerifyDays(.4, trip);
        }
        
        [TestMethod]
        public void ShouldCaculateCorrectNumberOfDaysMediumTrail()
        {
            var trail = GivenATrailObj(10, TrailDifficulty.Medium);
            var weather = GivenAWeatherObj(Precipitation.None, Temperature.AboveFreezingAndBelowSeventy);
            var trip = WhenATripIsCreated(weather, trail);
            ThenVerifyDays(.5, trip);
        }

        [TestMethod]
        public void ShouldCaculateCorrectNumberOfDaysHardTrail()
        {
            var trail = GivenATrailObj(10, TrailDifficulty.Hard);
            var weather = GivenAWeatherObj(Precipitation.None, Temperature.AboveFreezingAndBelowSeventy);
            var trip = WhenATripIsCreated(weather, trail);
            ThenVerifyDays(.7, trip);
        }
        #endregion
        #region precip
        [TestMethod]
        public void ShouldCaculateCorrectNumberOfDaysRain()
        {
            var trail = GivenATrailObj(10, TrailDifficulty.Medium);
            var weather = GivenAWeatherObj(Precipitation.Rain, Temperature.AboveFreezingAndBelowSeventy);
            var trip = WhenATripIsCreated(weather, trail);
            ThenVerifyDays(1, trip);
        }

        [TestMethod]
        public void ShouldCaculateCorrectNumberOfDaysSnow()
        {
            var trail = GivenATrailObj(10, TrailDifficulty.Medium);
            var weather = GivenAWeatherObj(Precipitation.Snow, Temperature.AboveFreezingAndBelowSeventy);
            var trip = WhenATripIsCreated(weather, trail);
            ThenVerifyDays(.7, trip);
        }
        #endregion
        #region Temp

        [TestMethod]
        public void ShouldCaculateCorrectNumberOfDaysSubZero()
        {
            var trail = GivenATrailObj(10, TrailDifficulty.Medium);
            var weather = GivenAWeatherObj(Precipitation.None, Temperature.SubZero);
            var trip = WhenATripIsCreated(weather, trail);
            ThenVerifyDays(1, trip);
        }

        [TestMethod]
        public void ShouldCaculateCorrectNumberOfDaysSubFreezingAboveZero()
        {
            var trail = GivenATrailObj(10, TrailDifficulty.Medium);
            var weather = GivenAWeatherObj(Precipitation.None, Temperature.SubFreezingAboveZero);
            var trip = WhenATripIsCreated(weather, trail);
            ThenVerifyDays(.7, trip);
        }

        [TestMethod]
        public void ShouldCaculateCorrectNumberOfDaysAboveSeventyAndBelowNinety()
        {
            var trail = GivenATrailObj(10, TrailDifficulty.Medium);
            var weather = GivenAWeatherObj(Precipitation.None, Temperature.AboveSeventyAndBelowNinety);
            var trip = WhenATripIsCreated(weather, trail);
            ThenVerifyDays(.7, trip);
        }

        [TestMethod]
        public void ShouldCaculateCorrectNumberOfDaysAboveNinety()
        {
            var trail = GivenATrailObj(10, TrailDifficulty.Medium);
            var weather = GivenAWeatherObj(Precipitation.None, Temperature.AboveNinety);
            var trip = WhenATripIsCreated(weather, trail);
            ThenVerifyDays(1, trip);
        }

        #endregion

        public void ShouldCaculateCorrectPace()
        {
            //TODO: Write this test!
        }

        public Weather GivenAWeatherObj(Precipitation precip, Temperature temp )
        {
            return new Weather(precip, temp);
        }
        public Trail GivenATrailObj( double length, TrailDifficulty difficulty)
        {
            return new Trail(length, difficulty, "Trail");
        }

        public Trip WhenATripIsCreated(Weather weather, Trail trail)
        {
            return new Trip("TheBestTripEver", weather, trail);
        }

        public void ThenVerifyDays(double days, Trip trip)
        {
            Assert.AreEqual(days, trip.Days);
        }


        #region Helper Methods

        #endregion
    }

}
