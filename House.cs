using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3noemberi
{
    internal class House : Building
    {
        public int Rooms;
        public double Area;
        public House(int floors, int doors, int windows, int rooms, double area) : base(floors, doors, windows)
        {
            Rooms = rooms;
            Area = area;
        }
        public void ShowData()
        {
            base.ShowData();
            Console.WriteLine("Rooms: " + Rooms);
            Console.WriteLine("Area: " + Area);
        }
    }
}
