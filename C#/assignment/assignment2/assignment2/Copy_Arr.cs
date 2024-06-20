using System;

class Copy_Arr
{
    static void Main()
    {
        int[] original = { 1, 2, 3, 4, 5 };
        int[] copied = new int[original.Length];
        for (int i = 0; i < original.Length; i++)
        {
            copied[i] = original[i];
        }
        Console.WriteLine("Elements of copiedArray:");
        foreach (int num in copied)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        Console.Read();
    }
}
