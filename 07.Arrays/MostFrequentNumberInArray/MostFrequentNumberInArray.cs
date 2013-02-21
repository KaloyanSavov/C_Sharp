using System;

class MostFrequentNumberInArray
{
    static void Main()
    {
        Console.WriteLine("Write a program that finds the most frequent number in an array.");
        Console.WriteLine("{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)");
        Console.WriteLine();
        Console.WriteLine("Enter the number of the elements in the array");
        int arrayElements = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Values of the elements: ");
        int[] array = new int[arrayElements + 1];
        for (int i = 0; i < arrayElements; i++)     // Fill the array with values
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        int equalNumbersCount = 1;
        int maxEqualNumbersCount = 0;
        int equalNumber = 1;
        if (arrayElements == 1)
        {
            Console.WriteLine("Enter at least two numbers");
        }
        else
        {
            for (int i = 0; i < arrayElements; i++) // Check if the current and next element are equal
            {
                if (array[i] == array[i + 1]) //If equal equalNumbersCount increaces with one and compares with maxEqualNumbersCount
                {
                    equalNumbersCount++;
                    if (equalNumbersCount > maxEqualNumbersCount)
                    {
                        maxEqualNumbersCount = equalNumbersCount;
                        equalNumber = array[i];
                    }
                }
                else //If not equal resets equalNumbersCount
                {
                    equalNumbersCount = 1;
                }
            }
            Console.Write("Number {0} ", equalNumber);
            Console.WriteLine("({0} times)" , maxEqualNumbersCount);
        }
    }
}
