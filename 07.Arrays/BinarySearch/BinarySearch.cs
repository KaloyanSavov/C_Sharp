using System;

class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).");
        Console.WriteLine();
        int[] array = { 2 , 3 , 4 , 6 , 9 };
        Console.WriteLine("This is our sorter array");
        for (int i = 0; i < array.Length; i++) //Print the array to console
        {
            Console.Write(" {0} " , array[i]);
        }
        Console.WriteLine();
        Console.WriteLine("We want the index of number 4");
        int number = 4;
        int maxValue = array.Length -1;
        int minValue = 0;
        int wantedNumber = - 1;
        while (maxValue >= minValue) //Binary Search
        {
            if (number > array[(minValue + maxValue)] / 2)
            {
                minValue = minValue + maxValue /2 + 1;
            }
            else if (number < array[(minValue + maxValue)] / 2 )
	        {
                maxValue = minValue + maxValue/ 2 - 1;
	        }
            else
            {
                wantedNumber = (minValue + maxValue) / 2;
                break;
            }
        }
        Console.WriteLine("The index of the wanted number is: {0}", wantedNumber);
    }
}