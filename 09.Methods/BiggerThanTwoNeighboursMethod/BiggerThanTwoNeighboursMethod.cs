using System;

class BiggerThanTwoNeighboursMethod
{
    static void BiggerThanTwoNeighbours(int[] array)
    {
        Console.WriteLine("Which element you want to check?");
        int element = int.Parse(Console.ReadLine());
        if (array[element] > array[element + 1] && array[element] > array[element - 1]) //Checking if the element is bigger than it's neighbours at the same time
        {
            Console.WriteLine("The element is bigger that it's two neighbours.");
        }
        else
        {
            Console.WriteLine("The element is not bigger that it's two neighbours.");
        }
    }
    static void Main()
    {
        Console.WriteLine("Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).");
        Console.WriteLine();
        Console.WriteLine("Enter a value for the array elements:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the values for the array elements:");
        int[] array = new int[number + 2];
        for (int i = 1; i < array.Length - 1; i++) //Fill the array
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        BiggerThanTwoNeighbours(array); //Calling method
    }
}
