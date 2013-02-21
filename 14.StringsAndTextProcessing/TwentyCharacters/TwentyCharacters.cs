using System;
using System.Text;

class TwentyCharacters
{
    static void Main()
    {
        Console.WriteLine("Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with '*'. Print the result string into the console.");
        Console.WriteLine();
        Console.WriteLine("Enter a text with lengt of maximum 20 characters:");
        string text = Console.ReadLine();
        if (text.Length > 20)
        {
            Console.WriteLine("The characters are more than 20");
        }
        else
        {
            string textNew = text.PadRight(20, '*');
            Console.WriteLine(textNew);
        }
    }
}
