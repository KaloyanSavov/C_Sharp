using System;
using System.Linq;

class SortingStringArrays
{
    static void ArraySort(string[] array)
    {
        array = array.OrderBy(x => x.Length).ToArray();
        Console.WriteLine();
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
    static void Main()
    {
        Console.WriteLine("You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).");
        Console.WriteLine();
        Console.WriteLine("Enter the number of the elements of the array:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the values for the array:");
        string[] array = new string[number];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Console.ReadLine();
        }
        ArraySort(array);
    }
}
