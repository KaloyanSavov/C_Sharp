using System;
using System.Text;

class WordsReverse
{
    static void Main()
    {
        Console.WriteLine("Write a program that reverses the words in given sentence.");
        Console.WriteLine("Example: \"C# is not C++, not PHP and not Delphi!\"");
        Console.WriteLine("\"Delphi not and PHP, not C++ not is C#!\".");
        Console.WriteLine();
        Console.WriteLine("This is out sentance:");
        Console.WriteLine("C# is not C++, not PHP and not Delphi!");
        string sentence = "C# is not C++, not PHP and not Delphi!";
        char[] punctuation = {'.' , ',' , '!' , ' '};
        string[] sentenceArray = sentence.Split(punctuation , StringSplitOptions.RemoveEmptyEntries);
        char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz+#".ToCharArray();
        string[] signs = sentence.Split(alphabet, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(sentenceArray);
        StringBuilder sentenceReverse = new StringBuilder();
        for (int i = 0; i < signs.Length; i++)
        {
            sentenceReverse.Append(sentenceArray[i]);
            sentenceReverse.Append(signs[i]);
        }
        Console.WriteLine(sentenceReverse.ToString());    
    }
}
