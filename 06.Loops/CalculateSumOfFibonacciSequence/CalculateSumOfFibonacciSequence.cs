using System;

class CalculateSumOfFibonacciSequence
{
    static void Main()
    {
        Console.WriteLine("Enter a value for the Fibonacci members:");
        int members = int.Parse(Console.ReadLine());
        int firstMember = 0;
        int secondMember = 1;
        int sum = 0;
        for (int i = 1; i <= members; i++)
        {
            sum = firstMember + secondMember;
            firstMember = secondMember;
            secondMember = sum;
        }
        Console.WriteLine("The sum of first {0} members is equal to: {1}" , members , secondMember - 1);
    }
}