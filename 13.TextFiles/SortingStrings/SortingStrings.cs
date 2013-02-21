using System;
using System.IO;

class SortingStrings
{
    static void Main()
    {
        Console.WriteLine("Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. Example:");
        Console.WriteLine("Ivan			George");
        Console.WriteLine("Peter	    Ivan");
        Console.WriteLine("Maria	->	Maria");
        Console.WriteLine("George		Peter");
        Console.WriteLine();
        StreamReader reader = new StreamReader("Names.txt");
        using (reader)
        {
            int lineCount = File.ReadAllLines("Names.txt").Length;
            string line = reader.ReadLine();
            string[] array = new string[lineCount];
            while (line != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = line;
                    line = reader.ReadLine();
                }
                
            }
            Array.Sort(array);
            StreamWriter writer = new StreamWriter("output.txt");
            using (writer)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    writer.WriteLine(array[i]);
                }
            }
        }
    }
}
