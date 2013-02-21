using System;
using System.IO;

class PrintOddLines
{
    static void Main()
    {
        Console.WriteLine("Write a program that reads a text file and prints on the console its odd lines.");
        Console.WriteLine();
        StreamReader reader = new StreamReader("Megadeth-Holy wars.txt");
        using (reader)
        {
            int lineNumber = 2;
            string line = reader.ReadLine();
            while (line != null)
            {
                if (lineNumber % 2 == 0)
                {
                    Console.WriteLine(line);
                }
                lineNumber++;
                line = reader.ReadLine();
            }
        }
    }
}
