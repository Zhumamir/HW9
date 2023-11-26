using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    class Program
    {
        static void Main()
        {
            Manager manager = new Manager("Rayan Gosling", 35, 50000, 10000);
            manager.GetInfo();
            Console.WriteLine($"Annual Salary: {manager.CalculateAnnualSalary()}");

            Console.WriteLine();

            Developer developer = new Developer("Alice Developer", 28, 60000, 1000);
            developer.GetInfo();
            Console.WriteLine($"Annual Salary: {developer.CalculateAnnualSalary()}");
        }
    }
}
