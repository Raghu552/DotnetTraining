using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class typeConversion
    {
        static void Main()
        {
            conversion();
            ternary();
            Console.Read();
        }
        static void conversion()
        {
            Console.WriteLine("Implicit Conversion");
            int x = 10;
            float y = x;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine("---------------------");
            Console.WriteLine("Explicit Conversion");
            float a = 10.98f;
            int b = (int)a;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine("---------------------");
            Console.WriteLine("Using Parse");
            string s = "100";
            int i = int.Parse(s);
            Console.WriteLine(s);
            Console.WriteLine(i);
            Console.WriteLine("---------------------");
            Console.WriteLine("Using tryParse");
            string str = "100g";
            int res = 0;
            bool num = int.TryParse(str,out res);
            if (true)
            {
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("not exist");
            }
            Console.WriteLine("---------------------");



        }
        static void ternary()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            bool b = num == 100 ? true : false;
            Console.WriteLine(b);
        }


    
    }
}
