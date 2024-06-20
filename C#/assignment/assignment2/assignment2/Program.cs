using System;

class Program
{
    static void Main()
    {
        int[] arr = { 5, 12, 3, 8, 9, 6, 15, 7, 10, 22, 55, 75 };
        double average = Avg(arr);
        Console.WriteLine($"Average value of array elements: {average}");
        int minValue = Minimum(arr);
        int maxValue = Maxi(arr);
        Console.WriteLine($"Minimum value in the array: {minValue}");
        Console.WriteLine($"Maximum value in the array: {maxValue}");
        Console.Read();
    }
    static double Avg(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        return (double)sum / arr.Length;
    }
    static int Minimum(int[] arr)
    {
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        return min;
    }
    static int Maxi(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }
}
