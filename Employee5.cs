using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3noemberi
{
    internal abstract class Employee5
    {
        public string Name { get; set; }
        public abstract double Pay();

        public Employee5(string name)
        {
            Name = name;
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Name - {Name}");
        }
    }
}
