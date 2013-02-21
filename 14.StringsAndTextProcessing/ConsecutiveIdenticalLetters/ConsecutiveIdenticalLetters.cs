using System;
using System.Text;
using System.Text.RegularExpressions;

class ConsecutiveIdenticalLetters
{
    static void Main()
    {
        Console.WriteLine("Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.");
        Console.WriteLine("aaaaabbbbbcdddeeeedssaa -> abcdedsa");
        Console.WriteLine();
        Console.WriteLine("Enter a sequence of letters");
        string letters = Console.ReadLine();
        string newSequence = Regex.Replace(letters, @"(\w)\1+", "$1");
        Console.WriteLine("This is the new sequence:");
        Console.WriteLine(newSequence);
    }
}
