using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class CountStr
    {
        public static void CountChar()
        {
            int count = 0;
            Console.WriteLine("enter a string");
            string str = Console.ReadLine();
            Console.WriteLine("enter a character that you want to see how many times repeating in a string");
            char ch = Convert.ToChar(Console.ReadLine());
            for(int i = 0; i <= str.Length-1; i++)
            {
                if (ch == str[i])
                {
                    count += 1;
                }
               
            }
            Console.WriteLine($"count of {ch} is {count}");
        }
        
    }
}
