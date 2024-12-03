using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3noemberi
{
    internal class Triangle : Shape
    {
        public double z;
        public string shapeName = "Triangle";
        public Triangle(double X, double Y, double Z) : base(X, Y)
        {
            z = Z;
            shapeName = "Triangle";
        }
        public void ShowData()
        {
            base.ShowData();
            Console.WriteLine("Z: " + z);
        }
        public override void Perimeter()
        {
            Console.WriteLine("Perimeter: " + (x + y + z));
        }
    }
}
