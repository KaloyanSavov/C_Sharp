using System;

class BetweenTwoNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        int firstNumberDivide = firstNumber / 5;
        int secondNumberDivide = secondNumber / 5;
        int difference = Math.Max(firstNumberDivide, secondNumberDivide) - Math.Min(firstNumberDivide, secondNumberDivide);
        Console.WriteLine("P({0},{1})={2}", firstNumber, secondNumber, difference);
    }
}
