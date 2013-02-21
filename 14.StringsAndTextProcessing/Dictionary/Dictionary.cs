using System;
using System.Text;

    class Dictionary
    {
        static void Main()
        {
            Console.WriteLine("A dictionary is stored as a sequence of text lines containing words and their explanations. Write a program that enters a word and translates it by using the dictionary. Sample dictionary:");
            Console.WriteLine(".NET – platform for applications from Microsoft");
            Console.WriteLine("CLR – managed execution environment for .NET");
            Console.WriteLine("namespace – hierarchical organization of classes");
            Console.WriteLine();
            Console.WriteLine("Our Dictionary contain these words:");
            Console.WriteLine("Andoid, iOS , WindowsPhone");
            Console.WriteLine("Enter a word from the dictionary");
            string word = Console.ReadLine();
            string[] words = { "android", "ios", "windowsphone" };
            string[] explanation = { "Google mobile OS", "Apple mobile OS", "Microsoft mobile OS" };
            for (int i = 0; i < words.Length; i++)
			{
                if (word.ToLower() == words[i])
                {
                    Console.WriteLine(explanation[i]);
                }
			}
        }
    }
