using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3
{
    public class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public Box(double len, double breadth)
        {
            Length = len;
            Breadth = breadth;
        }
        public static Box Add(Box box1, Box box2)
        {
            double newLength = box1.Length + box2.Length;
            double newBreadth = box1.Breadth + box2.Breadth;
            Box result = new Box(newLength, newBreadth);
            return result;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Length: {Length}, Breadth: {Breadth}");
        }
    }
}
