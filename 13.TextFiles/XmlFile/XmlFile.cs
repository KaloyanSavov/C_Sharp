using System;
using System.IO;
using System.Text.RegularExpressions;

class XmlFile
{
    static void Main()
    {
        Console.WriteLine("Write a program that extracts from given XML file all the text without the tags. Example:");
        Console.WriteLine("<?xml version=\"1.0\"><student><name>Pesho</name><age>21</age><interests count=\"3\"><interest> Games</instrest><interest>C#</instrest><interest> Java</instrest></interests></student>");
        Console.WriteLine();
        StreamReader reader = new StreamReader("text.xml");
        StreamWriter writer = new StreamWriter("output.txt");
        using (reader)
        {
            using (writer)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string text = Regex.Replace(line, "<(.*?)>", " ");
                    writer.WriteLine(text);
                    line = reader.ReadLine();
                }
            }  
        }
    }
}
