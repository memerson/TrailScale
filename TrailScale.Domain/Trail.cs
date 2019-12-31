using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrailScale.Domain
{
   public class Trail
    {
        public double length { get; }
        public TrailDifficulty difficulty { get; }
       public string name { get; }

        public Trail(double trailLength, TrailDifficulty trailDifficulty, string trailName)
        {
            length = trailLength;
            difficulty = trailDifficulty;
            name = trailName;
        }
    }
}
