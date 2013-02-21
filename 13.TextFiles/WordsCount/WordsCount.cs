using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class WordsCount
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Write a program that reads a list of words from a file words.txt and finds how many times each of the words is contained in another file test.txt. The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order. Handle all possible exceptions in your methods.");
            Console.WriteLine();
            StreamReader readText = new StreamReader("test.txt");
            StreamReader readWord = new StreamReader("words.txt");
            StreamWriter writer = new StreamWriter("result.txt");
            using (readText)
            {
                using (readWord)
                {
                    using (writer)
                    {
                        List<string> word = new List<string>();
                        string wordFile = readWord.ReadLine();
                        while (wordFile != null)
                        {
                            word.Add(wordFile);
                            wordFile = readWord.ReadLine();
                        }
                        int[] counts = new int[word.Count];
                        for (string line; (line = readText.ReadLine()) != null; )
                        {
                            for (int i = 0; i < word.Count; i++)
                            {
                                counts[i] += Regex.Matches(line, @"\b" + word[i] + @"\b").Count;
                            }
                        }
                        for (int i = 0; i < counts.Length; i++)
                        {
                            writer.WriteLine("{0} - {1} times", word[i], counts[i]);
                        }
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not Found");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory is not found");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You don't have permitions to read this file");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Wrong path");
        }
    }
}
