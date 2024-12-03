using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3noemberi
{
    internal class Shape
    {
        public double x;
        public double y;
        public string shapeName;
        public Shape(double X, double Y)
        {
            x = X;
            x = y;
        }
        public void ShowData()
        {
            Console.WriteLine("Shape Name: " + shapeName);
            Perimeter();
            Console.WriteLine("X: " + x);
            Console.WriteLine("Y: " + y);
        }
        public virtual void Perimeter()
        {
        }
    }
}
