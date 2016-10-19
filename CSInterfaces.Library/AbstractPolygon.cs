using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSInterfaces.Library
{
    public abstract class AbstractPolygon
    {
        public int NumberOfSides { get; set; }
        public int Length { get; set; }

        public AbstractPolygon(int sides, int length)
        {
            NumberOfSides = sides;
            Length = length;
        }

        public double GetPerimeter()
        {
            double perimeter;
            perimeter = Length * NumberOfSides;
            return perimeter;
        }

        public abstract double GetArea();
    }
}
