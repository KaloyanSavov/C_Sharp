using System;
using System.Numerics;

class NthCatalanNumber
{
    static void Main()
    {
        Console.WriteLine("Cn = (2n)!/(1 + n)!*n!");
        Console.Write("Enter a value for n: ");
        int number = int.Parse(Console.ReadLine());
        BigInteger firstFactorial = 1;
        BigInteger secondFactorial = 1;
        BigInteger thirdFactorial = 1;
        for (int i = number * 2; i > 0; i--)
        {
            firstFactorial *= i;
        }
        for (int j = number + 1; j > 0; j--)
        {
            secondFactorial *= j;
        }
        for (int k = number; k > 0; k--)
        {
            thirdFactorial *= k;
        }
        BigInteger catalanNumber = firstFactorial / (secondFactorial * thirdFactorial);
        Console.WriteLine("Cn = {0}" , catalanNumber);
    }
}