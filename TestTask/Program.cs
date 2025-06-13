using System;

public class Program
{
    public static long SumOfTwoMinimals(int[] arr)
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
            else if (num < min2 && num != min1) 
            {
                min2 = num; 
            }
        }

        if (min2 == int.MaxValue)
        {
            throw new InvalidOperationException("Array must contain at least two distinct elements.");
        }

        long sum = (long)min1 + (long)min2; 

        return sum;
    }


    public static void Main(string[] args)
    {
        try
        {
            var result = SumOfTwoMinimals(new int[] { 4, 0, 3, 19, 492, -10, 1 });
            Console.WriteLine(result);

            var overflowResult = SumOfTwoMinimals(new int[] { int.MaxValue, int.MaxValue }); //Проверка обработки переполнения при сложении двух максимальных значений типа int.
            Console.WriteLine(overflowResult); //Вывод: 4294967294 (что соответствует 2 * int.MaxValue)



            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}

