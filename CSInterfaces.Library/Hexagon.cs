using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSInterfaces.Library
{
    public class Hexagon : IPolygonInterface
    {
        public int NumberOfSides { get; set; }
        public int Length { get; set; }

        public Hexagon(int length)
        {
            NumberOfSides = 8;
            Length = length;
        }
        public double GetPerimeter()
        {
            return NumberOfSides * Length;
        }

        public double GetArea()
        {
            return Length * Length * 1.5 * Math.Sqrt(3); 
        }
    }
}
