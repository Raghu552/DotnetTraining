using System;
using System.Collections.Generic;


public abstract class student
{
    public string name { get; set; }
    public int id { get; set; }
    public double grade { get; set; }
    public abstract bool Ispassed(double grade);
}
public class undergraduate : student
{
    public override bool Ispassed(double grade)
    {
        return grade > 70.0;
        
    }
}
public class graduate : student
{
    public override bool Ispassed(double grade)
    {
        return grade > 80.0;
    }
}
public class Product : IComparable<Product>
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Price { get; set; }
    public int CompareTo(Product other)
    {
        if (other == null)
        {
            return 1;
        }
        else
        {
            return this.Price.CompareTo(other.Price);
        }
        
    }
}
public class Program
{
    public static void Producteg()
    {
        List<Product> products = new List<Product>();
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Enter details for Product {i}:");
            Product product = new Product();

            Console.Write("Product ID: ");
            product.ProductId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Product Name: ");
            product.ProductName = Console.ReadLine();

            Console.Write("Price: ");
            product.Price = Convert.ToInt32(Console.ReadLine());

            products.Add(product);
        }
        products.Sort();
        Console.WriteLine("Sorted Products based on Price:");
        foreach (var product in products)
        {
            Console.WriteLine($"Product ID: {product.ProductId}, Product Name: {product.ProductName}, Price: {product.Price}");
        }
    }

    public static void NegativeExceptioneg()
    {
        try
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            CheckNumber(number);
            Console.WriteLine("No exception thrown. The number is non-negative.");
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine($"There is no such longer number: {e.Message}");
        }
        catch (FormatException e)
        {
            Console.WriteLine($"Input error: {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Unexpected error: {e.Message}");
        }
    }

    public static void CheckNumber(int number)
    {
        if (number < 0)
        {
            throw new FormatException("The number cannot be negative.");
        }
    }
    public static void Main()
    {
        undergraduate ug = new undergraduate();
        Console.WriteLine("enter your Id");
        ug.id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter your Name");
        ug.name = Console.ReadLine();
        Console.WriteLine("enter your grade");
        ug.grade= Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{ug.name} passed: {ug.Ispassed(ug.grade)}");
        Console.WriteLine("--------------------------------");
        graduate g = new graduate();
        Console.WriteLine("enter your Id");
        g.id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter your Name");
        g.name = Console.ReadLine();
        Console.WriteLine("enter your grade");
        g.grade = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{g.name} passed: {g.Ispassed(g.grade)}");
        Console.WriteLine("--------------------------------");
        Producteg();
        Console.WriteLine("--------------------------------");
        NegativeExceptioneg();
        Console.WriteLine("--------------------------------");
        Console.Read();
    }
}


