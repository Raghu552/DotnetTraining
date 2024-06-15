using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_number
{
    class checkNum
    {
        static void Main(string[] args)
        {
            int a = 10;
            if (a < 0)
            {
                Console.WriteLine("its a negative numer");
            }
            else
            {
                Console.WriteLine("its a positive number");
            }
            Console.Read();
        }
    }
}
