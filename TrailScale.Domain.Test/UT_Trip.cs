using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrailScale.Domain;

namespace TrailScale.Domain.Test
{
    [TestClass]
    public class UT_Trip
     {
        #region Properties
        Weather mWeather;
        Trip mTrip;
        Trail mTrail;

        #endregion

        [TestMethod]
        public void ShouldCreateANewTrip()
        {
            GivenATrailObj();
            GivenAWeatherObj();
            WhenATripIsCreated();
        }

        public void GivenAWeatherObj()
        {
            mWeather = new Weather(Precipitation.Snow, Temperature.AboveSeventyAndBelowNinety);
        }
        public void GivenATrailObj()
        {
            mTrail = new Trail(10.4, TrailDifficulty.Easy, "AwesomeTrail");
        }

        public void WhenATripIsCreated()
        {
            mTrip = new Trip("TheBestTripEver", mWeather, mTrail);
        }

        public void ThenATripIsNotNull()
        {
            Assert.IsNotNull(mTrip);
        }
    }

}
