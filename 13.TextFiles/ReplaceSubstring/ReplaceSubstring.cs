using System;
using System.IO;

class ReplaceSubstring
{
    static void Main()
    {
        Console.WriteLine("Write a program that replaces all occurrences of the substring \"start\" with the substring \"finish\" in a text file. Ensure it will work with large files (e.g. 100 MB).");
        Console.WriteLine();
        Console.WriteLine("Used input file is 102MB and the program needs few seconds to replace the substring in the whole file.");
        StreamReader reader = new StreamReader("text.txt"); //text.txt is 102MB long
        StreamWriter writer = new StreamWriter("output.txt");
        using (reader)
        {
            using (writer)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string replace = line.Replace("start", "end");
                    writer.WriteLine(replace);
                    line = reader.ReadLine();
                }
            }
        }
    }
}
