using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWord
{
    static void Main()
    {
        Console.WriteLine("Modify the solution of the previous problem to replace only whole words (not substrings).");
        Console.WriteLine();
        Console.WriteLine("Used input file is 102MB and the program needs about 10 seconds to replace the word in the whole file.");
        StreamReader reader = new StreamReader("text.txt"); //text.txt is 102MB long
        StreamWriter writer = new StreamWriter("output.txt");
        using (reader)
        {
            using (writer)
            {
                string word = "\\b(start)\\b"; ;
                Regex rgx = new Regex(word);
                string line = reader.ReadLine();
                while (line != null)
                {
                    string replace = rgx.Replace(line, "end");
                    writer.WriteLine(replace);
                    line = reader.ReadLine();
                }
            }
        }
    }
}
