using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{ 
    public class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public Box(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }
        public static Box Add(Box box1, Box box2)
        {
            double newLength = box1.Length + box2.Length;
            double newBreadth = box1.Breadth + box2.Breadth;
            return new Box(newLength, newBreadth);
        }
        public void Display()
        {
            Console.WriteLine($"Length: {Length}, Breadth: {Breadth}");
        }
    }

    public class BoxTest
    {
        static void Main()
        {
            Box box1 = new Box(5.2, 3.8);
            Box box2 = new Box(2.5, 4.3);
            Box box3 = Box.Add(box1, box2);
            Console.WriteLine("Dimensions of Box3 after addition:");
            box3.Display();
            Console.Read();
        }
    }
}
