using System;

class ReadThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        int sum = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine("The sum is equal to {0}: ", sum);
    }
}
