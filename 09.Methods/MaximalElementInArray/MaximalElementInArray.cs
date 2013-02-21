using System;

class MaximalElementInArray
{
    static void FindingMaximalElement(int[] array , int startingNumber) //Finds the maximal element from the part of the array
    {
        int maxNumber = 0;
        for (int i = startingNumber; i < array.Length; i++)
			{
                if (array[i] > maxNumber)
                {
                    maxNumber = array[i];
                }
			}
        Console.WriteLine("The maximal element in the portion of the array is {0}", maxNumber);
    }
    static void AscendingOrderSorting(int[] array)
    {
        int tempValue = 0;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            for (int j = array.Length - 1; j >= 0; j--)
            {
                if (array[j] < array[i])
                {
                    tempValue = array[j];
                    array[j] = array[i];
                    array[i] = tempValue;
                }
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
    static void DescendingORderSorting(int[] array)
    {
        int tempValue = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] < array[i])
                {
                    tempValue = array[j];
                    array[j] = array[i];
                    array[i] = tempValue;
                }
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
    static void Main()
    {
        Console.WriteLine("Write a method that return the maximal element in a portion of array of integers starting at given index. Using it write another method that sorts an array in ascending / descending order.");
        Console.WriteLine();
        int[] array = { 5, 1, 3, 6, 2, 7, 9, 8, 4 };
        Console.WriteLine("This is our array:");
        for (int i = 0; i < array.Length; i++) //Write the array to the console
        {
            Console.Write("{0} " , array[i]);
        }
        Console.WriteLine();
        Console.WriteLine("Enter a starting index:");
        int startingNumber = int.Parse(Console.ReadLine());
        FindingMaximalElement(array, startingNumber); //Calling method
        Console.WriteLine("Enter 1 for ascending or 2 for descending sort of the array:");
        int number = int.Parse(Console.ReadLine());
        if (number == 1)
        {
            AscendingOrderSorting(array); //Calling method
        }
        else
        {
            DescendingORderSorting(array); //Calling method
        }
    }
}
