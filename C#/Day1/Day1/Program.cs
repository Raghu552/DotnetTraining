using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your first name: ");
            string fname = Console.ReadLine();
            Console.WriteLine("enter your last name: ");
            string lname = Console.ReadLine();
            Console.WriteLine($"your name is {fname}{lname}");
            Console.WriteLine("-------------------------");
            Program prog = new Program();
            Console.WriteLine("Text");
            prog.display(Console.ReadLine());
            Console.WriteLine("-------------------------");
            int sum= add(5, 3);
            Console.WriteLine("Sum is " + sum);
            Console.Read();
        }
        void display(string name)
        {
            Console.WriteLine("Hi "+name);
        }
        static int add(int a, int b)
        {
            return a + b;
        }
    }
}
