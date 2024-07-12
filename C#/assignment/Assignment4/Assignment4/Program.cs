using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        public static void display()
        {
            Console.WriteLine("1.-------------------");
            Console.WriteLine("Enter first name ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name ");
            string lastName = Console.ReadLine();
            Console.WriteLine(firstName.ToUpper());
            Console.WriteLine(lastName.ToUpper());
        }
        static void Main(string[] args)
        {
            display();
            Console.WriteLine("2.-------------------");
            Count.CountChar();
            Console.WriteLine("4.-------------------");
            Scholarship.Merit();
            Console.WriteLine("5.-------------------");
            Doctor doctor1 = new Doctor(1035591, "Dr.Reddy", 150);
            doctor1.DisplayDetails();
            Console.WriteLine("======After setting values======");
            doctor1.RegnNo = 234768;
            doctor1.Name = "Dr. Cherry";
            doctor1.FeesCharged = 200;
            doctor1.DisplayDetails();
            Console.Read();
        }
    }
}
