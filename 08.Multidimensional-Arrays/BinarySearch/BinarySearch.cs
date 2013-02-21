using System;

class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is <= K.");
        Console.WriteLine();
        Console.WriteLine("Enter the number of the elements of the array:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the values for the array:");
        int[] array = new int[number];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter a value for  K:");
        int k = int.Parse(Console.ReadLine());
        Array.Sort(array);      //Sorting Array before using Binary Search
        int searched = Array.BinarySearch(array, k);
        if (searched > 0)
        {
            Console.WriteLine("Biggest number that is lower or equal to k is {0}" , array[searched]);
        }
        else if (~searched > 0)
        {
            Console.WriteLine("The biggest number that is lower or equal to K is {0}" , array[~searched - 1]);
        }
        else if (searched == 0)
        {
            Console.WriteLine("The biggest number that is lower or equal to K is {0}", array[searched]);
        }
        else if (searched == -1)
        {
            Console.WriteLine("There is no number that is lower or equal to K");
        }

    }
}
