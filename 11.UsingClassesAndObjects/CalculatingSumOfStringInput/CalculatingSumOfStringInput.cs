using System;

class CalculatingSumOfStringInput
{
    static void Main()
    {
        Console.WriteLine("You are given a sequence of positive integer values written into a string, separated by spaces. Write a function that reads these values from given string and calculates their sum. Example:");
        Console.WriteLine("string = 43 68 9 23 318 -> result = 461");
        Console.WriteLine();
        Console.WriteLine("Enter a sequence of positive intiger numbers separated by space");
        string numbers = Console.ReadLine();
        string[] separateNumbers = numbers.Split(' '); //Separating the numbers
        int[] numbersSeparate = new int[separateNumbers.Length]; 
        int result = 0;
        for (int i = 0; i < separateNumbers.Length; i++) //Put the numbers in int array after parsing them
        {
            numbersSeparate[i] = int.Parse(separateNumbers[i]);
        }
        for (int i = 0; i < numbersSeparate.Length; i++)
        {
            result += numbersSeparate[i];
        }
        Console.WriteLine("Result {0}" , result); // Print result
    }
}
