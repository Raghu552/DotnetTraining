using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            int sub = a - b;
            int mul = a * b;
            int div = a / b;
            Console.WriteLine($"addition is {sum}");
            Console.WriteLine($"substraction is {sub}");
            Console.WriteLine($"multiplication is {mul}");
            Console.WriteLine($"division is {div}");
            Console.Read();





        }

    }
}
