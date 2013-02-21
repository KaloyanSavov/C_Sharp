using System;

class MaxSequenceSumInArray
{
    static void Main()
    {
        Console.WriteLine("Write a program that finds the sequence of maximal sum in given array.");
        Console.WriteLine("{2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}");
        Console.WriteLine();
        Console.WriteLine("Enter the number of the elements in the array");
        int arrayElements = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Values of the elements: ");
        int[] array = new int[arrayElements];
        for (int i = 0; i < arrayElements; i++)     // Fill the array with values
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int sum = 0;
        int maxSum = 0;
        int startOfSequence = 0;
        int endOfSequence = 0;
        for (int i = 0; i < arrayElements; i++) //Finds the maximum sequence
        {
            sum = array[i];
            for (int j = i + 1; j < arrayElements; j++)
            {
                sum = sum + array[j];
                if (sum > maxSum)
	            {
		            maxSum = sum;
                    startOfSequence = i;
                    endOfSequence = j;
	            }
            }
        }
        for (int i = startOfSequence; i <= endOfSequence; i++) //Print the maximum sequence
        {
            Console.Write("{0} " , array[i]);
        }
        Console.WriteLine();
        Console.WriteLine(maxSum); // Prints the sum of the sequence
    }
}
