using System;

class GreaterNumber
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        int greaterNumber = Math.Max(firstNumber, secondNumber);
        Console.WriteLine("Greater number is: {0}", greaterNumber);
    }
}
