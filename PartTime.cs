using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3noemberi
{
    internal class PartTime : Employee5
    {
        public double hours { get; set; }
        public double hourPay { get; set; }
        public override double Pay()
        {
            return hours * hourPay;
        }
        public PartTime(string name, double hours, double hourPay) : base(name)
        {
            this.hours = hours;
            this.hourPay = hourPay;
            this.Name = name;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Hours - {hours}\nPay - {hourPay}");
        }
    }
}
