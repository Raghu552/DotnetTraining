using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Scholarship
    {
        public static void Merit()
        {
            Console.WriteLine("enter your marks");
            int marks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the total fees");
            int fees = Convert.ToInt32(Console.ReadLine());
            if (marks>=70 && marks <= 80)
            {
                int discount1 = (20 * fees) / 100;
                fees -= discount1;
            }
            else if(marks>80 && marks <= 90)
            {
                int discount2 = (30 * fees) / 100;
                fees -= discount2;
            }
            else if (marks > 90)
            {
                int discount3 = (50 * fees) / 100;
                fees -= discount3;
            }
            else
            {
                Console.WriteLine("no deduction in fees");
            }
            Console.WriteLine($"for your {marks} marks you have to pay {fees} ruppes");
        }
    }
}
