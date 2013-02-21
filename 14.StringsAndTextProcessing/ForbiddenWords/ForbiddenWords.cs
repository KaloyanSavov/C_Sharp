using System;
using System.Text;

class ForbiddenWords
{
    static void Main()
    {
        Console.WriteLine("We are given a string containing a list of forbidden words and a text containing some of these words. Write a program that replaces the forbidden words with asterisks. Example:");
        Console.WriteLine("Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.");
        Console.WriteLine("Words: \"PHP, CLR, Microsoft\"");
        Console.WriteLine("The expected result:");
        Console.WriteLine("********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.");
        Console.WriteLine();
        Console.WriteLine("We use the same text.");
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string[] forbiddenWords = { "PHP" , "CLR" , "Microsoft" };
        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            text = text.Replace(forbiddenWords[i], new string('*', forbiddenWords[i % forbiddenWords.Length].Length));
        }
        Console.WriteLine();
        Console.WriteLine("This is our new text");
        Console.WriteLine(text);
    }
}
