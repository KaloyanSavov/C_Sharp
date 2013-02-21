using System;

class QuickSort
{
    static void Main()
    {
        Console.WriteLine("Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).");
        Console.WriteLine();
        int[] array = { 3, 1, 2, 8, 4, 6, 5, 9, 7 };
        Console.WriteLine("This is our array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(" {0} " , array[i]);
        }
        int tempValue = 0;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            for (int j = array.Length - 1; j >= 0; j--)
            {
                if (array[j] < array[i]) // Sorting the array
                {
                    tempValue = array[j];
                    array[j] = array[i];
                    array[i] = tempValue;
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("Sorted array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(" {0} " , array[i]);
        }
        Console.WriteLine();
    }
}
