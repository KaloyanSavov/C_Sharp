using System;

class ExactSumInArray
{
    static void Main()
    {
        Console.WriteLine("Write a program that finds in given array of integers a sequence of given sum S (if present).");
        Console.WriteLine("{4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}");
        Console.WriteLine();
        Console.WriteLine("Enter the number of the elements in the array");
        int arrayElements = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Values of the elements: ");
        int[] array = new int[arrayElements];
        for (int i = 0; i < arrayElements; i++)     // Fill the array with values
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter a wanted sum: ");
        int wantedSum = int.Parse(Console.ReadLine());
        int sum = 0;
        int startOfSequence = 0;
        int endOfSequence = 0;
        for (int i = 0; i < arrayElements; i++) //Searching elements for the wanted sum
        {
            sum = array[i];
            for (int j = i + 1; j < arrayElements; j++)
            {
                sum = sum + array[j];
                if (sum == wantedSum) //If we find the wanted sum we brake the cycle
                {
                    startOfSequence = i;
                    endOfSequence = j;
                    break;
                }
            }
        }
        for (int i = startOfSequence; i <= endOfSequence; i++) //Print the sequence
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }
}
