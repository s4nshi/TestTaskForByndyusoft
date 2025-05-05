using System;

public class Program
{
    public static int SumOfTwoMinimals(int[] arr)
    {
        if (arr == null || arr.Length < 2)
        {
            throw new ArgumentException("Array must contain at least two elements.");
        }

        int min1 = int.MaxValue;
        int min2 = int.MaxValue;

        foreach (var num in arr)
        {
            if (num < min1)
            {
                min2 = min1; 
                min1 = num; 
            }
            else if (num < min2)
            {
                min2 = num; 
            }
        }

        return min1 + min2;
    }

    public static void Main(string[] args)
    {
        var result = SumOfTwoMinimals(new int[] { 4, 0, 3, 19, 492, -10, 1 });
        Console.WriteLine(result); 
        Console.ReadKey();
    }
}

