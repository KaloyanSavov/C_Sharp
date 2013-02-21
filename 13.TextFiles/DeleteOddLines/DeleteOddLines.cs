using System;
using System.IO;
using System.Collections.Generic;

class DeleteOddLines
{
    static void Main()
    {
        Console.WriteLine("Write a program that deletes from given text file all odd lines. The result should be in the same file.");
        Console.WriteLine();
        Console.WriteLine("If you want to see original text look at \"Original Text.txt\"");
        StreamReader reader = new StreamReader("Megadeth-Holy wars.txt");
        List<string> lines = new List<string>();
        using (reader)
        {
            int lineNumber = 2;
            int lineCount = File.ReadAllLines("Megadeth-Holy wars.txt").Length;
            string line = reader.ReadLine();
            while (line != null)
            {
                for (int i = 0; i < lineCount; i++)
                {
                    if (lineNumber % 2 != 0)
                    {
                        lines.Add(line);
                    }
                    lineNumber++;
                    line = reader.ReadLine();
                }
            }
        }
        StreamWriter writer = new StreamWriter("Megadeth-Holy wars.txt");
        using (writer)
        {
            for (int i = 0; i < lines.Count; i++)
            {
                writer.WriteLine(lines[i]);
            }
        }
    }
}
