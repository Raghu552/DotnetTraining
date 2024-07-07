using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment6
{
    public class Startswith_Endswith
    {
        public static void Startswith_Endswith1()
        {
            Console.WriteLine("Enter how many strings you want :");
            int n = Convert.ToInt32(Console.ReadLine());
            List<string> words = new List<string> ();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter string {i + 1}:");
                string values = Console.ReadLine();
                words.Add(values);
            }
            var result = words.Where(word => word.StartsWith("a") && word.EndsWith("m")).ToList();
            Console.WriteLine("Words starting with 'a' and ending with 'm':");
            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
            Console.Read();
        }
    }
}
