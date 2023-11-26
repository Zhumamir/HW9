using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    class Developer : Employee
    {
        private int linesOfCodePerDay;

        public Developer(string name, int age, double salary, int linesOfCodePerDay)
            : base(name, age, salary)
        {
            this.linesOfCodePerDay = linesOfCodePerDay;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Lines of Code per Day: {linesOfCodePerDay}");
        }

        public override double CalculateAnnualSalary()
        {
            double additionalPayment = linesOfCodePerDay * 0.1 * 365;
            return base.CalculateAnnualSalary() + additionalPayment;
        }
    }
}
