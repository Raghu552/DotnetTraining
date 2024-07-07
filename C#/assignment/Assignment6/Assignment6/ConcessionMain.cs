using System;
using Concession; 

class Program
{
     const double TotalFare = 500;
    public static void Main()
    {
        Console.WriteLine("Welcome to Travel Ticket Booking System");
        Console.WriteLine("--------------------------------------");
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        string concession = ConcessionLibrary.Concession1(age);
        Console.WriteLine("Booking Details:");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Concession: {concession}");
        Console.WriteLine("Thank you for using our service!");
        Console.ReadLine();
    }
}
