using System;
using System.Text;

class SubstringCount
{
    static void Main()
    {
        Console.WriteLine("Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).");
        Console.WriteLine();
        Console.WriteLine("This is our text:");
        Console.WriteLine("We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.");
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        Console.WriteLine();
        Console.WriteLine("We are searching for substring \"in\"");
        string substring = "in";
        int count = 0;
        for (int i = 0; i < text.Length - 2; i++)
        {
            if (text.Substring(i , 2).ToLower() == substring)
            {
                count++;
                i++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("The count of substring \"in\" is: {0}" , count);
    }
}
