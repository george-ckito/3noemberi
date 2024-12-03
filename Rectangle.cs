using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3noemberi
{
    internal class Rectangle : Shape
    {
        public Rectangle(double X, double Y) : base(X, Y)
        {
            shapeName = "Rectangle";
        }
        public override void Perimeter()
        {
            Console.WriteLine("Perimeter: " + (2 * x + 2 * y));
        }
    }
}
