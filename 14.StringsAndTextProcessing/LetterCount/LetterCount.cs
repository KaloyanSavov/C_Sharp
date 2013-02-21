using System;
using System.Text;
using System.Collections.Generic;

class LetterCount
{
    static void Main()
    {
        Console.WriteLine("Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.");
        Console.WriteLine();
        Console.WriteLine("Enter some text:");
        string text = Console.ReadLine();
        char[] splitText = text.ToCharArray();
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach (var letter in splitText)
        {
            if (dict.ContainsKey(letter))
            {
                dict[letter] = dict[letter] + 1;
            }
            else
            {
                dict.Add(letter, 1);
            }
        }
        foreach (var letter in dict)
        {
            Console.WriteLine("{0} {1}", letter.Key, letter.Value);
        }
    }
}
