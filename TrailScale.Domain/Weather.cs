using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrailScale.Domain
{
    public class Weather
    {
        public Precipitation Precipitation { get; }
        public Temperature Temperature { get; }

        public Weather(Precipitation tripPrecipitation, Temperature temp)
        {
            Precipitation = tripPrecipitation;
            Temperature = temp;

        }
    }
}
