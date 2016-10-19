using CSInterfaces.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSInterfaces.ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(4);
            ShowShape("Square", square);

            var triangle = new Triangle(4);
            ShowShape("Triangle", triangle);

            var hexagon = new Hexagon(4);
            ShowShape("Hexagon", hexagon);

            Console.Read();
        }

        public static void ShowShape(string shapeType, dynamic shapeName)
        {
            try
            {
                Console.WriteLine("{0} Number of Sides {1}", shapeType, shapeName.NumberOfSides);
                Console.WriteLine("{0} Length: {1}", shapeType, shapeName.Length);
                Console.WriteLine("{0} Perimeter: {1}", shapeType, shapeName.GetPerimeter());
                Console.WriteLine("{0} Area: {1} \n", shapeType, shapeName.GetArea());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception for {0}:\n {1} " + shapeType, ex.GetType().Name);
            }
        }
    }
}
 
