using System;
using System.Text;

class ListInAlphabeticalOrder
{
    static void Main()
    {
        Console.WriteLine("Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.");
        Console.WriteLine();
        Console.WriteLine("Enter some words separated by space");
        string words = Console.ReadLine();
        string[] array = words.Split(' ');
        Array.Sort(array);
        for (int i = 0; i < array.Length; i++)
		{
            Console.WriteLine(array[i]);
		}
    }
}
