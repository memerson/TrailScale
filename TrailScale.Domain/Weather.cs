using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrailScale.Domain
{
    public class Weather
    {
        public Precipitation precipitation { get; }
        public Temperature temperature { get; }

        public Weather(Precipitation tripPrecipitation, Temperature temp)
        {
            precipitation = tripPrecipitation;
            temperature = temp;

        }
    }
}
