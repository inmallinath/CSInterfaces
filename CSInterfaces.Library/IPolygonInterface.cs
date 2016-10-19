using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSInterfaces.Library
{
    public interface IPolygonInterface
    {
        int NumberOfSides { get; set; }
        int Length { get; set; }

        double GetPerimeter();
        double GetArea();
    }
}
