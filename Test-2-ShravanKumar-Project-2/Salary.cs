using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2_ShravanKumar_Project_2
{
    internal class Salary:Employee
    {
        public double HRA { get; set; }
        public double TA { get; set; }
        public double DA { get; set; }
        public double Tax { get; set; }
        public double NetSalary { get; set; }

        public override void TaxCalculation()
        {
            
            if (Salary < 10000)
            {
                HRA = Salary * 0.2;
                TA = Salary * 0.1;
                DA = Salary * 0.15;
                Tax = Salary * 0.1;
            }
            else
            {
                HRA = Salary * 0.3;
                TA = Salary * 0.15;
                DA = Salary * 0.2;
                Tax = Salary * 0.2;
            }
            NetSalary = Salary + HRA + TA + DA - Tax;
        
        }
        public override void DisplayEmployeeDetails()
        {
            Console.WriteLine("\n\t***EMPLOYEE dETAILS***");
            Console.WriteLine("Employee Id: " + EmployeeId);
            Console.WriteLine("Employee Name: " + EmployeeName);
            Console.WriteLine("Employee Salary: " + Salary);
        }
        public override  void DisplaySalaryDetails()
        {
            Console.WriteLine("\n\tSalary Details::");
            Console.WriteLine("HRA: " + HRA);
            Console.WriteLine("TA: " + TA);
            Console.WriteLine("DA: " + DA);
            Console.WriteLine("Tax: " + Tax);
            Console.WriteLine("\nAnd Net Salary:: " + NetSalary);
        }
    }
}
