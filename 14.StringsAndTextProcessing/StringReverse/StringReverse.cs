using System;
using System.Text;

class StringReverse
{
    static void Main()
    {
        Console.WriteLine("Write a program that reads a string, reverses it and prints the result at the console.");
        Console.WriteLine("Example: \"sample\" -> \"elpmas\".");
        Console.WriteLine();
        Console.WriteLine("Enter a word:");
        string word = Console.ReadLine();
        StringBuilder reverseWors = new StringBuilder();
        for (int i = word.Length - 1; i >= 0; i--)
			{
			    reverseWors.Append(word[i]);
			}
        Console.WriteLine(reverseWors.ToString());
    }
}
