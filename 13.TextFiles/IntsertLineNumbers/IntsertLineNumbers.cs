using System;
using System.IO;

class IntsertLineNumbers
{
    static void Main()
    {
        Console.WriteLine("Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file.");
        Console.WriteLine();
        StreamReader read = new StreamReader("Megadeth-She Wolf.txt");
        using (read)
        {
            StreamWriter write = new StreamWriter("Megadeth-She Wolf Numbers.txt");
            using(write)
	        {
                string line = read.ReadLine();
                int lineNumber = 1;
                while (line != null)
                {
                    write.Write("{0}. ", lineNumber);
                    write.WriteLine(line);
                    lineNumber++;
                    line = read.ReadLine();
                }
	        }
        }
    }
}
