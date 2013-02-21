using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

class ExtractFromHTML
{
    static void Main()
    {
        Console.WriteLine("Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.");
        Console.WriteLine();
        StreamReader reader = new StreamReader("page.html");
        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                string text = Regex.Replace(line, "<(.*?)>", " ");
                Console.WriteLine(text);
                line = reader.ReadLine();
            }
        }
    }
}
