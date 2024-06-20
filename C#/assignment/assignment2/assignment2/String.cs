using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class String
    {
        static void Main()
        {
            Console.WriteLine("enter a string ");
            len(Console.ReadLine());
            Console.WriteLine("-----------------------");
            Console.WriteLine("enter a string ");
            rev(Console.ReadLine());
            Console.WriteLine("-----------------------");
            same(Console.ReadLine(), Console.ReadLine());
            Console.Read();
        }
        static void len(string s)
        {
            Console.WriteLine("length of the string is "+s.Length);
        }
        static void rev(string s)
        {
            string revstr = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                revstr += s[i];
            }
            Console.WriteLine("String after reverse is " + revstr);
        }
        static void same(string s1, string s2)
        {
            if (s1 == s2)
            {
                Console.WriteLine("they are same");
            }
            else
            {
                Console.WriteLine("they are not same");
            }
        }
    }
}
