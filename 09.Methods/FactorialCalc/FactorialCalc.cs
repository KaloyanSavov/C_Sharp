using System;
using System.Numerics;

class FactorialCalc
{
    static void Factorial(int[] array) //With this method prints all factorials from 1! to 100!
    {                                   //We use BigEnteger because the factorials have very big values
        BigInteger factorial = 1;
        for (int i = 1; i < array.Length; i++)
        {
            for (int j = i; j >= 1; j--)
            {
                factorial *= j;
            }
            Console.WriteLine(factorial);
            factorial = 1;
        }
        
    }
    static void Main()
    {
        Console.WriteLine("Write a program to calculate n! for each n in the range [1..100]. Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.");
        Console.WriteLine();
        int[] array = new int[100];
        Factorial(array);
    }
}
