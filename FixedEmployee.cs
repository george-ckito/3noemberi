using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3noemberi
{
    internal class FixedEmployee : Employee
    {
        public decimal fixedSalary { get; set; }
        public FixedEmployee(string firstName, string lastName, string phoneNumber, decimal fixedSalary) : base(firstName, lastName, phoneNumber)
        {
            this.fixedSalary = fixedSalary;
        }
        public override decimal GetSalary()
        {
            return fixedSalary;
        }
        public void ShowData()
        {
            base.ShowData();
            Console.WriteLine("Fixed Salary: " + fixedSalary);
        }
    }
}
