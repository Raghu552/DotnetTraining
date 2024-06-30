using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public interface IStudent
    {
        int StudentId { get; set; }
        string Name { get; set; }
    }
    public class Dayscholar : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public Dayscholar(int studentId, string name)
        {
            StudentId = studentId;
            Name = name;
        }
        public void ShowDetails()
        {
            Console.WriteLine($"Dayscholar Details:");
            Console.WriteLine($"Student ID: {StudentId}");
            Console.WriteLine($"Name: {Name}");
        }
    }

    public class Resident : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public Resident(int studentId, string name)
        {
            StudentId = studentId;
            Name = name;
        }
        public void ShowDetails()
        {
            Console.WriteLine($"Resident Details:");
            Console.WriteLine($"Student ID: {StudentId}");
            Console.WriteLine($"Name: {Name}");
        }
    }
    public class Student
    {
        static void Main()
        {
            Dayscholar dayscholar = new Dayscholar(001, "Raghu");
            Resident resident = new Resident(002, "Reddy");
            dayscholar.ShowDetails();
            Console.WriteLine("--------------");
            resident.ShowDetails();
            Console.Read();
        }
    }
}
