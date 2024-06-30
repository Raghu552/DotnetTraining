using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public float Salary { get; set; }
        public Employee(int empId, string empName, float salary)
        {
            EmpId = empId;
            EmpName = empName;
            Salary = salary;
        }
        public void Display()
        {
            Console.WriteLine($"Employee ID: {EmpId}");
            Console.WriteLine($"Employee Name: {EmpName}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }

    public class ParttimeEmployee : Employee
    {
        public float Wages { get; set; }
        public ParttimeEmployee(int empId, string empName, float salary, float wages)
            : base(empId, empName, salary)
        {
            Wages = wages;
        }
        public new void Display()
        {
            base.Display();
            Console.WriteLine($"Wages: {Wages}");
        }
    }

    public class EmployeeTest
    {
        static void Main()
        {
            ParttimeEmployee parttimeEmployee = new ParttimeEmployee(552, "Raghu", 30000.0f, 15.0f);
            Console.WriteLine("Details of Part-time Employee:");
            parttimeEmployee.Display();
            Console.Read();
        }
    }
}
