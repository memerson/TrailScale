using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrailScale.Domain
{
    public enum TrailDifficulty
    {
        Easy = 0,
        Medium = 1,
        Hard = 2
    }

    public enum Precipitation
    {
        None = 0,
        Rain = 1,
        Snow = 2
    }

    public enum Temperature
    {
        SubZero = 0,
        SubFreezingAboveZero = 1,
        AboveFreezingAndBelowSeventy = 2,
        AboveSeventyAndBelowNinety = 3,
        AboveNinety = 4

    }
}
