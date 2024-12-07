using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3noemberi
{
    internal class FullTime : Employee5
    {
        public decimal salary { get; set; }
        public FullTime(string name, decimal salary) : base(name)
        {
            this.Name = name;
            this.salary = salary;
        }
        public override double Pay() {
            return (double) salary;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Salary - {this.Pay()}");
        }
    }
}
