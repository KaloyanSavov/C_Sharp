using System;

class SortingArray
{
    static void Main()
    {
        Console.WriteLine("Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.");
        Console.WriteLine();
        Console.WriteLine("Enter the number of the elements in the array");
        int arrayElements = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Values of the elements: ");
        int[] array = new int[arrayElements];
        for (int i = 0; i < arrayElements; i++)     // Fill the array with values
		{
			array[i] = int.Parse(Console.ReadLine());
		}
        int minNumber = 0;
        int temp = 0;
        for (int i = 0; i < arrayElements; i++) // This is the first compared element
		{
            minNumber = array[i];
            for (int j = i + 1; j < arrayElements; j++)     // This is the second compared element
            {
                if (array[j] < minNumber)
                {
                    temp = minNumber;
                    array[i] = array[j]; //Switching the two elements
                    array[j] = temp;
                    minNumber = array[i];
                }
            }
		}
        Console.WriteLine("Sorted array");
        for (int i = 0; i < arrayElements; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
