using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Swap
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int temp;
            Console.WriteLine("before swap a is " + a);
            Console.WriteLine("before swap b is " + b);
            temp = a;
            a = b;
            b = a;
            b = temp;
            Console.WriteLine("After swap a is "+a);
            Console.WriteLine("After swap b is "+b);
            Console.Read();

        }
    }
}
