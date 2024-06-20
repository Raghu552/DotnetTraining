using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Number
    {
        static void Main()
        {
            Console.WriteLine("enter a number1 ");
            int a =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("enter a number2 ");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (a == b)
            {
                sum = (a + b) * 3;
                Console.WriteLine("2 numbers are same, triple of their sum is " + sum);
            }
            else
            {
                sum = a + b;
                Console.WriteLine("2 numbers are not same,  their sum is " + sum);
            }
            Console.Read();
        }
    }
}
