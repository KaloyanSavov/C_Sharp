using System;

class LetterSearch
{
    static void Main()
    {
        Console.WriteLine("Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.");
        Console.WriteLine();
        char[] alphabet = new char[27]; //This is the array with alphabet
        int letter = 97;
        for (int i = 1; i < 27; i++)
        {
            alphabet[i] = (char)letter;
            letter++;
        }
        Console.WriteLine("Enter a a word: ");
        string word = Console.ReadLine();
        char[] wordInLetters = word.ToCharArray(); // We put the word in char array
        for (int i = 0; i < wordInLetters.Length; i++)
        {
            for (int j = 1; j < 27; j++)
            {
                if (wordInLetters[i] == alphabet[j])
                {
                    Console.WriteLine("Letter {0} - Number {1}", alphabet[j] , j); //Print the number in alphabet of the letter
                }
            }
        }
    }
}
