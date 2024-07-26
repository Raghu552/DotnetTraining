using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Assignment
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }
    class program
    {
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>()
            {
                new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984,11,16), DOJ = new DateTime(2011,6,8), City = "Mumbai" },
                new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
                new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 4, 12), City = "Pune" },
                new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" },
                new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
                new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
                new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 6, 1), City = "Mumbai" },
                new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 6), City = "Chennai" },
                new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 8, 12), DOJ = new DateTime(2014, 12, 3), City = "Chennai" },
                new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 1, 2), City = "Pune" }
            };
            var emp1 = emplist.Where(e => e.DOJ > new DateTime(2015, 1, 1));
            Console.WriteLine("Employees joined before 01/01/2015");
            foreach(var item in emp1)
            {
                Console.WriteLine($"{item.EmployeeID},{item.FirstName},{item.LastName}");
            }
            Console.WriteLine("-----------------------------------------------------------------------");
            var emp2 = emplist.Where(e => e.DOB > new DateTime(1990,1,1));
            Console.WriteLine("Employees whose date of birth is after 1/1/1990:");
            foreach (var employee in emp2)
            {
                Console.WriteLine($"{employee.EmployeeID} {employee.FirstName} {employee.LastName}");
            }
            Console.WriteLine("-----------------------------------------------------------------------");

            var CandA = emplist.Where(e => e.Title == "Consultant" || e.Title == "Associate");
            Console.WriteLine("Employees whose designation is Consultant and Associate:");
            foreach (var employee in CandA)
            {
                Console.WriteLine($"{employee.EmployeeID} {employee.FirstName} {employee.LastName} {employee.Title}");
            }
            Console.WriteLine("-----------------------------------------------------------------------");

            Console.WriteLine("Total number of employees: " + emplist.Count());
            Console.WriteLine("-----------------------------------------------------------------------");

            var Employees_in_chennai = emplist.Where(e => e.City == "Chennai");
            Console.WriteLine("Total number of employees belonging to Chennai: " + Employees_in_chennai.Count());
            Console.WriteLine("-----------------------------------------------------------------------");

            var highestEmployeeID = emplist.Max(e => e.EmployeeID);
            Console.WriteLine("Highest employee ID: " + highestEmployeeID);
            Console.WriteLine("-----------------------------------------------------------------------");

            var emp3 = emplist.Where(e => e.DOJ > new DateTime(2015,1,1));
            Console.WriteLine("Total number of employees who have joined after 1/1/2015: " + emp3.Count());
            Console.WriteLine("-----------------------------------------------------------------------");

            var non_Associates = emplist.Where(e => e.Title != "Associate");
            Console.WriteLine("Total number of employees whose designation is not Associate: " + non_Associates.Count());
            Console.WriteLine("-----------------------------------------------------------------------");

            var cityGroups = emplist.GroupBy(e => e.City);
            Console.WriteLine("Total number of employees based on City:");
            foreach (var group in cityGroups)
            {
                Console.WriteLine($"{group.Key}: {group.Count()}");
            }
            Console.WriteLine("-----------------------------------------------------------------------");

            var cityTitleGroups = emplist.GroupBy(e => new { e.City, e.Title });
            Console.WriteLine("Total number of employees based on City and Title:");
            foreach (var group in cityTitleGroups)
            {
                Console.WriteLine($"{group.Key.City} {group.Key.Title}: {group.Count()}");
            }
            Console.WriteLine("-----------------------------------------------------------------------");

            var youngestEmployee = emplist.OrderByDescending(e => e.DOB).First();
            Console.WriteLine("\nYoungest employee: " + youngestEmployee.FirstName + " " + youngestEmployee.LastName);
            Console.Read();
        }
    }
}
