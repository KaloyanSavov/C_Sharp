using System;
using System.IO;

class CompareTwoFiles
{
    static void Main()
    {
        Console.WriteLine("Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different. Assume the files have equal number of lines.");
        Console.WriteLine();
        StreamReader readFirstFile = new StreamReader("First File.txt");
        StreamReader readSecondFile = new StreamReader("Second File.txt");
        int equal = 0;
        int nonEqual = 0;
        using (readFirstFile)
        {
            using (readSecondFile)
            {
                string lineFirsFile = readFirstFile.ReadLine();
                string lineSecondFile = readSecondFile.ReadLine();
                while (lineFirsFile != null && lineSecondFile != null)
                {
                    if (lineFirsFile == lineSecondFile)
                    {
                        equal++;
                    }
                    else
                    {
                        nonEqual++;
                    }
                    lineFirsFile = readFirstFile.ReadLine();
                    lineSecondFile = readSecondFile.ReadLine();
                }
            }
        }
        Console.WriteLine("Equal lines: {0}" , equal);
        Console.WriteLine("Non equal lines: {0}", nonEqual);
    }
}
