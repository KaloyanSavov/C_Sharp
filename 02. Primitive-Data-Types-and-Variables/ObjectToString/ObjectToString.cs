using System;

class ObjectToString
{
    static void Main()
    {
        string firstWord = "Hello";
        string secondWord = "World";
        object combination = firstWord + " " + secondWord;
        string a = (string)combination;
        Console.WriteLine(a);
    }
}
