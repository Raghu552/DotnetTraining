using System;

namespace CC4
{

    public delegate int Calci(int a, int b);

    class Calculator_using_Delegates
    {
        public static void Delegate()
        {
            Calci addition = Add;
            Calci subtraction = Sub;
            Calci multiplication = Mul;
            Console.WriteLine("enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int Adding = Calculating(addition, num1, num2);
            Console.WriteLine($"Addition: {num1} + {num2} = {Adding}");

            int Subtracting = Calculating(subtraction, num1, num2);
            Console.WriteLine($"Subtraction: {num1} - {num2} = {Subtracting}");

            int Multipling = Calculating(multiplication, num1, num2);
            Console.WriteLine($"Multiplication: {num1} * {num2} = {Multipling}");
        }
        static int Calculating(Calci begin, int a, int b)
        {
            return begin(a, b);
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Sub(int a, int b)
        {
            return a - b;
        }
        static int Mul(int a, int b)
        {
            return a * b;
        }
    }
}
