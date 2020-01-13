using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrailScale.Domain
{
   public class Trail
    {
        public double Length { get; }
        public TrailDifficulty Difficulty { get; }
       public string Name { get; }

        public Trail(double trailLength, TrailDifficulty trailDifficulty, string trailName)
        {
            Length = trailLength;
            Difficulty = trailDifficulty;
            Name = trailName;
        }
    }
}
