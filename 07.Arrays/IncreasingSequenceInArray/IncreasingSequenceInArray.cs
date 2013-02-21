using System;

class IncreasingSequenceInArray
{
    static void Main()
    {
        Console.WriteLine("Write a program that finds the maximal increasing sequence in an array.");
        Console.WriteLine("Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}");
        Console.WriteLine();
        Console.WriteLine("Enter the number of the elements in the array");
        int arrayElements = int.Parse(Console.ReadLine());
        int[] firstArray = new int[arrayElements + 1];  // The array have one more element to prevent IndexOutOfRangeException
        Console.WriteLine("Enter the values for the array:");
        for (int i = 0; i < arrayElements; i++) // Fill the array with values
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        int sequenceElementsCount = 1;
        int maxSequenceElementsCount = 1;
        int sequenceStart = 0;
        int count = -1;
        for (int i = 0; i < arrayElements; i++) // Check the current and next member
        {
            if (firstArray [i + 1] - firstArray [i] == 1 ) // If the difference between next element and current element is one there is a sequence
            {
                sequenceElementsCount++;
                if (sequenceElementsCount > maxSequenceElementsCount)
                {
                    maxSequenceElementsCount = sequenceElementsCount;
                    sequenceStart = firstArray[i];
                    count++; // Count is used to count how many times sequenceStart changes its value
                }
            }
            else
            {
                sequenceElementsCount = 1;
            }
        }
        Console.Write("The maximum increasing sequence in the array is: ");
        for (int i = 0; i < maxSequenceElementsCount; i++)
        {
            
            Console.Write(" {0} " , sequenceStart - count); // Print the sequence
            sequenceStart++;
        }
        Console.WriteLine();
    }
}