using System;
using System.IO;
using System.Text.RegularExpressions;

class TestPrefix
{
    static void Main()
    {
        Console.WriteLine("Write a program that deletes from a text file all words that start with the prefix \"test\". Words contain only the symbols 0...9, a...z, A…Z, _.");
        Console.WriteLine();
        StreamReader reader = new StreamReader("testing.txt");
        StreamWriter writer = new StreamWriter("output.txt");
        using (reader)
        {
            using (writer)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string text = Regex.Replace(line, @"(\b)test((\d|\w|_)*)(\b)", " ");
                    writer.WriteLine(text);
                    line = reader.ReadLine();
                }
            }
        }
    }
}

