using System;

class NumberCountInArrayMethod
{
    static int NumberCountInArray(int[] array)
    {
        
        Console.WriteLine("Enter the number that you want to know how many times appears in the array:");
        int wantedNumber = int.Parse(Console.ReadLine()); // This is the number that we want to check
        int count = 0;                          // We use this variable to count how many times the wanted number is in the array
        for (int i = 0; i < array.Length; i++)
			{
                if (array[i] == wantedNumber)
                {
                    count++;
                }
			}
        return count; // When the check of the array is over we returns the count of the wanted number
    }
    static void Main()
    {
        Console.WriteLine("Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.");
        Console.WriteLine();
        Console.WriteLine("Enter a value for the array elements:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the values for the array elements:");
        int[] array = new int[number];
        for (int i = 0; i < array.Length; i++)  // Fill the array with numbers
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The wanted number appears {0} times in the array." , NumberCountInArray(array)); //Calling method
    }
}
