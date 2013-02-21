using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class RemoveFromTextFile
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Write a program that removes from a text file all words listed in given another text file. Handle all possible exceptions in your methods.");
            Console.WriteLine();
            StreamReader readText = new StreamReader("text.txt");
            StreamReader readWord = new StreamReader("word.txt");
            StreamWriter writer = new StreamWriter("output.txt");
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
                        string line = readText.ReadLine();
                        while (line != null)
                        {
                            for (int i = 0; i < word.Count; i++)
                            {
                                string wordReplace = "\\b" + word[i] + "\\b";
                                line = Regex.Replace(line, wordReplace, "");
                            }
                            writer.WriteLine(line);
                            line = readText.ReadLine();
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
