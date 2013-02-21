using System;
using System.Text;
using System.Collections.Generic;

class WordsCount
{
    static void Main()
    {
        Console.WriteLine("Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.");
        Console.WriteLine();
        Console.WriteLine("Enter some text:");
        string text = Console.ReadLine();
        char[] separators = { '.', ',', ' ' };
        string[] splitText = text.Split(separators , StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> dict = new Dictionary<string, int>();
        foreach (var word in splitText)
        {
            if (dict.ContainsKey(word))
            {
                dict[word] = dict[word] + 1;
            }
            else
            {
                dict.Add(word, 1);
            }
        }
        foreach (var word in dict)
        {
            Console.WriteLine("{0} {1}" , word.Key , word.Value);
        }
    }
}
