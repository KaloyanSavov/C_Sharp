using System;
using System.Text;

class ExtractPalindromes
{
    static void Main()
    {
        Console.WriteLine("Write a program that extracts from a given text all palindromes, e.g. \"ABBA\", \"lamal\", \"exe\"");
        Console.WriteLine();
        Console.WriteLine("Enter some text:");
        string text = Console.ReadLine();
        string[] textArray = text.Split(' ');
        bool palindrome = true; ;
        for (int i = 0; i < textArray.Length; i++)
        {
            for (int j = 0; j < textArray[i].Length; j++)
            {
                if ((textArray[i])[j] != (textArray[i])[(textArray[i].Length - 1 - j)])
                {
                    palindrome = false;
                    break;
                }
            }
            if (palindrome == true)
            {
                Console.WriteLine(textArray[i]);
                
            }
            palindrome = true;
        }

    }
}
