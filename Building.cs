using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3noemberi
{
    internal class Building
    {
        public int Floors;
        public int Doors;
        public int Windows;
        public Building(int floors, int doors, int windows)
        {
            Floors = floors;
            Doors = doors;
            Windows = windows;
        }
        public void ShowData()
        {
            Console.WriteLine("Floors: " + Floors);
            Console.WriteLine("Doors: " + Doors);
            Console.WriteLine("Windows: " + Windows);
        }
    }
}
