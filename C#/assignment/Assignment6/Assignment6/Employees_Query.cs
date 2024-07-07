using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment6
{
    class Employees_Query
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpCity { get; set; }
        public decimal EmpSalary { get; set; }
       public static void Main()
        {
            List<Employees_Query> employees = new List<Employees_Query>
        {
            new Employees_Query { EmpId = 1, EmpName = "John Doe", EmpCity = "Bangalore", EmpSalary = 50000 },
            new Employees_Query { EmpId = 2, EmpName = "Jane Smith", EmpCity = "Chennai", EmpSalary = 48000 },
            new Employees_Query { EmpId = 3, EmpName = "Michael Johnson", EmpCity = "Bangalore", EmpSalary = 55000 },
            new Employees_Query { EmpId = 4, EmpName = "Emily Brown", EmpCity = "Mumbai", EmpSalary = 42000 },
            new Employees_Query { EmpId = 5, EmpName = "David Lee", EmpCity = "Bangalore", EmpSalary = 47000 }
        };
            Console.WriteLine("All Employees:");
            DisplayEmployees(employees);
            Console.WriteLine("Employees with Salary > 45000:");
            var highSalaryEmployees = employees.Where(e => e.EmpSalary > 45000);
            DisplayEmployees(highSalaryEmployees);
            Console.WriteLine("Employees from Bangalore:");
            var bangaloreEmployees = employees.Where(e => e.EmpCity.Equals("Bangalore"));
            DisplayEmployees(bangaloreEmployees);
            Console.WriteLine("Employees sorted by Name Ascending:");
            var employeesByName = employees.OrderBy(e => e.EmpName);
            DisplayEmployees(employeesByName);
            Console.Read();
        }
        static void DisplayEmployees(IEnumerable<Employees_Query> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"EmpId: {emp.EmpId}, EmpName: {emp.EmpName}, EmpCity: {emp.EmpCity}, EmpSalary: {emp.EmpSalary}");
            }
        }
    }
}
