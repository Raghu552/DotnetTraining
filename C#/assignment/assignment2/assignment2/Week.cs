using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Week
    {
        static void Main()
        {
            Console.WriteLine("enter a number from 1 to 7");
            int a =Convert.ToInt32( Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine("It's monday");
            }
            else if (a == 2)
            {
                Console.WriteLine("It's tuesday");
            }
            else if (a == 3)
            {
                Console.WriteLine("It's wednesday");
            }
            else if (a == 4)
            {
                Console.WriteLine("It's thursday");
            }
            else if (a == 5)
            {
                Console.WriteLine("It's friday");
            }
            else if (a == 6)
            {
                Console.WriteLine("It's saturday");
            }
            else if (a == 7)
            {
                Console.WriteLine("It's sunday");
            }
            Console.Read();

        }
    }
}
