using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Array
    {
        static void Main()
        {
            int[] marks = new int[10];
            Console.WriteLine("Enter ten marks:");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Mark {i}: ");
                marks[i] = int.Parse(Console.ReadLine());
            }
            int total = Total(marks);
            Console.WriteLine($"Total marks: {total}");
            double average = Avg(marks);
            Console.WriteLine($"Average marks: {average}");
            int minMarks = Minimum(marks);
            int maxMarks = Maxi(marks);
            Console.WriteLine($"Minimum marks: {minMarks}");
            Console.WriteLine($"Maximum marks: {maxMarks}");
            Console.Read();
        }
        static int Total(int[] marks)
        {
            int sum = 0;
            foreach (int mark in marks)
            {
                sum += mark;
            }
            return sum;
        }
        static double Avg(int[] marks)
        {
            int total = Total(marks);
            return (double)total / marks.Length;
        }
        static int Minimum(int[] marks)
        {
            int min = marks[0];
            foreach (int mark in marks)
            {
                if (mark < min)
                {
                    min = mark;
                }
            }
            return min;
        }
        static int Maxi(int[] marks)
        {
            int max = marks[0];
            foreach (int mark in marks)
            {
                if (mark > max)
                {
                    max = mark;
                }
            }
            return max;
            
        }
    }
}
