using System;

class GreatestCommonDivisorOfTwoNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter a value for the first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a value for the second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        int temp;
        if (firstNumber == secondNumber)
        {
            Console.WriteLine("First number is equal to second number");
        }
        if (firstNumber > secondNumber)
        {
            while (firstNumber % secondNumber != 0)
            {
             temp = firstNumber % secondNumber;
             firstNumber = secondNumber;
             secondNumber = temp;
            }
            Console.WriteLine("The gratest common divisor is: {0}" , secondNumber);
        }
        if (secondNumber > firstNumber)
        {
            while (secondNumber % firstNumber != 0)
            {
             temp = secondNumber % firstNumber;
             secondNumber = firstNumber;
             firstNumber = temp;
            }
            Console.WriteLine("The gratest common divisor is: {0}" , firstNumber);
        }
    }
}