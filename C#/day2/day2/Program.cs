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
            int x = 10;
            Console.WriteLine("call by value");
            callbyValue(x);
            Console.WriteLine("After callbyvalue X is " + x);
            Console.WriteLine("----------------");
            Console.WriteLine("call by Reference");
            callbyRef(ref x);
            Console.WriteLine("After callbyref X is " + x);
            Console.WriteLine("----------------");
            int s, ss, m, div = 0;
            div= calculator(10, 5,out s,out ss,out m);
            Console.WriteLine($"add is {s} sub is {ss} mul is {m} div is {div}");
            Console.Read();
        }
        static void callbyValue(int j)
        {
            j = 100;
            Console.WriteLine("After callbyvalue J is " + j);
        }
        static void callbyRef(ref int j)
        {
            j = 100;
            Console.WriteLine("After call by ref J is "+j);
        }
        static int calculator(int a, int b, out int sum, out int sub, out int mul)
        {
            sum = a + b;
            sub = a - b;
            mul = a * b;
            return a / b;
        }
    }
}
