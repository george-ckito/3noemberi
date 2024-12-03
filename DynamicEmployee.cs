using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3noemberi
{
    internal class DynamicEmployee : Employee
    {
        public decimal hourlyRate { get; set; }
        public decimal hoursWorked { get; set; }
        public DynamicEmployee(string firstName, string lastName, string phoneNumber, decimal hourlyRate, decimal hoursWorked) : base(firstName, lastName, phoneNumber)
        {
            this.hourlyRate = hourlyRate;
            this.hoursWorked = hoursWorked;
        }
        public override decimal GetSalary()
        {
            return hourlyRate * hoursWorked;
        }
        public void ShowData()
        {
            base.ShowData();
            Console.WriteLine("Hourly Rate: " + hourlyRate);
            Console.WriteLine("Hours Worked: " + hoursWorked);
        }
    }
}
