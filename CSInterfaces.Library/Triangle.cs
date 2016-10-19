using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSInterfaces.Library
{
    public class Triangle : AbstractPolygon
    {
        public Triangle(int length) : base(3, length)
        {
        }

        public override double GetArea()
        {
            return NumberOfSides * Length * Math.Sqrt(3) / 4;
        }
    }
}
