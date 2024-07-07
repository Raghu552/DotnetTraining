using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment6
{
    public class Program
    {
        public static void Square()
        {
            Console.WriteLine("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter number {i + 1}:");
                int num = Convert.ToInt32(Console.ReadLine());
                numbers.Add(num);
            }
            var result = numbers.Where(num => num * num > 20).Select(num => $"{num} - {num * num}");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        public static void Main()
        {
            Square();
            Startswith_Endswith.Startswith_Endswith1();
            Console.Read();
        }
    }
}