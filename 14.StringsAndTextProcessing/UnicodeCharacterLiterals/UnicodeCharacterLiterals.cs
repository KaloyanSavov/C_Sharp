using System;
using System.Text;

class UnicodeCharacterLiterals
{
    static void Main()
    {
        Console.WriteLine("Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. Sample input:");
        Console.WriteLine("Hi!");
        Console.WriteLine("Expected output:");
        Console.WriteLine("\\u0048\\u0069\\u0021");
        Console.WriteLine();
        Console.WriteLine("Enter a word:");
        string word = Console.ReadLine();
        char[] array = word.ToCharArray();
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("\\u{0:X4}" , (int)array[i]);
        }
        Console.WriteLine();
    }
}
