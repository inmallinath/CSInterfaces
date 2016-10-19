using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSInterfaces.Library
{
    public class ConcretePolygon
    {
        public int NumberOfSides { get; set; }
        public int Length { get; set; }

        public ConcretePolygon(int sides, int length)
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

        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
