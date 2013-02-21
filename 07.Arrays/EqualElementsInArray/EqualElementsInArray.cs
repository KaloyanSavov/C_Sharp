using System;

class EqualElementsInArray
{
    static void Main()
    {
        Console.WriteLine("Write a program that finds the maximal sequence of equal elements in an array.");
        Console.WriteLine("Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.");
        Console.WriteLine();
        Console.WriteLine("Enter the number of the elements in the array");
        int arrayElements = int.Parse(Console.ReadLine());
        int[] firstArray = new int[arrayElements + 1];  // The array have one more element to prevent IndexOutOfRangeException
        Console.WriteLine("Enter the values for the array:");
        for (int i = 0; i < arrayElements; i++) // Fill the array with values
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }
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
                if (firstArray[i] == firstArray[i + 1]) //If equal equalNumbersCount increaces with one and compares with maxEqualNumbersCount
                {
                    equalNumbersCount++;
                    if (equalNumbersCount > maxEqualNumbersCount)
                    {
                        maxEqualNumbersCount = equalNumbersCount;
                        equalNumber = firstArray[i];
                    }
                }
                else //If not equal resets equalNumbersCount
                {
                    equalNumbersCount = 1;
                }
            }
            Console.Write("The maximumm sequence of equal elements for the array is:");
            for (int i = 0; i < maxEqualNumbersCount; i++) // Print the equal elemnets
            {
                Console.Write(" {0} ", equalNumber);
            }
            Console.WriteLine();
        }
    }
}
