using System;
using System.IO;

class ConcatenatesTwoFiles
{
    static void Main()
    {
        Console.WriteLine("Write a program that concatenates two text files into another text file.");
        Console.WriteLine();
        StreamReader readFirstFile = new StreamReader("Megadeth-She Wolf.txt");
        StreamReader readSecondFile = new StreamReader("Megadeth-1320.txt");
        using (readFirstFile)
        {
            string line = readFirstFile.ReadLine();
            StreamWriter writeOnFile = new StreamWriter("Megadeth.txt" , false);
            using (writeOnFile)
            {
                while (line != null)
                {
                    writeOnFile.WriteLine(line);
                    line = readFirstFile.ReadLine();
                }

            }
        }
        using (readSecondFile)
        {
            string line = readSecondFile.ReadLine();
            StreamWriter writeOnFile = new StreamWriter("Megadeth.txt" , true);
            using (writeOnFile)
            {
                 while (line != null)
                {
                    writeOnFile.WriteLine(line);
                    line = readSecondFile.ReadLine();
                }
            }
        }

    }
}
