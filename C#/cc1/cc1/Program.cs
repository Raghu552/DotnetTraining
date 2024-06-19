using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc1
{
    class Program
    {
        static void Main(string[] args)
        {
            table(5);
            Console.WriteLine("------------------------");
            Console.WriteLine("enter the string");
            rev(Console.ReadLine());
            Console.WriteLine("------------------------");
            Console.WriteLine("enter the numbers");
            largest(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("------------------------");
            Console.WriteLine("enter the string");
            index(Console.ReadLine());
            Console.Read();
        }
        static void table(int i)
        {
            int num = 10;
            for(int j=1;j<=num;j++)
            {
                Console.WriteLine($"{i} * {j} is "+i * j);
            }
        }
        static void rev(string s)
        {
            string revstr = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                revstr += s[i];
            }
            Console.WriteLine("String after reverse is "+revstr);
        }
        static void largest(int a, int b ,int c)
        {
            int large = 0;
            if (a > b && a > c)
            {
                large = a;
            }
            else if(b>a && b > c)
            {
                large = b;
            }
            else
            {
                large = c;
            }
            Console.WriteLine("largest is " + large);
        }
        static void index(string str)
        {
            Console.WriteLine("enter index number");
            int userIndex = Convert.ToInt32(Console.ReadLine());
            for (int k = 0; k < str.Length+1; k++)
            {
                if (k == userIndex)
                {
                    continue;
                }
                Console.WriteLine(str[k]);

            }


        }
    }
}
