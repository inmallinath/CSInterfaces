using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSInterfaces.Library
{
    public class Square : ConcretePolygon
    {
        public Square(int length) : base(4, length)
        {
        }

        public override double GetArea()
        {
            return Length * Length;
        }
    }
}
