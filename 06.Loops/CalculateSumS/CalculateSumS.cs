using System;

class CalculateSumS
{
    static void Main()
    {
        Console.WriteLine("Enter a Value for N:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a value for X:");
        int x = int.Parse(Console.ReadLine());
        double sum = 1;
        double factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                factorial *= j;
            }
            sum += factorial / Math.Pow(x, i);
            factorial = 1;
        }
        Console.WriteLine("Sum S is equal to: {0}", sum);
    }
}