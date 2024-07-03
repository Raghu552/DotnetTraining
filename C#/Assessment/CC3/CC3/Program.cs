using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3
{
    class Cricket
    {
        public static void PointsCalculation(int no_of_matches)
        {
            int[] arr = new int[no_of_matches];
            int sum = 0;
            for (int i = 0; i < no_of_matches; i++)
            {
                Console.WriteLine($"enter the {i + 1} match score");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }
            Console.WriteLine($"the sum for all scores is {sum}");
            double avg = sum / no_of_matches;
            Console.WriteLine($"the average score for all matches is {avg}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of matches");
            Cricket.PointsCalculation(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("--------------------");
            Console.WriteLine("enter the lenght and breadth of box1");
            Box box1 = new Box(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("enter the lenght and breadth of box2");
            Box box2 = new Box(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            Box box3 = Box.Add(box1, box2);
            Console.WriteLine("Details of Box 3:");
            box3.DisplayDetails();
            Console.Read();
        }
    }
}
