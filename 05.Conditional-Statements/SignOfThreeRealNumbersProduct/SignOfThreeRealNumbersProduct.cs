using System;

class SignOfThreeRealNumbersProduct
{
    static void Main()
    {
        Console.WriteLine("Enter the first real number;");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second real number");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third real number");
        int thirdNumber = int.Parse(Console.ReadLine());
        if (firstNumber < 0 && secondNumber < 0 && thirdNumber < 0)
        {
            Console.WriteLine("The sign of the product is '-'");
        }
        else if (firstNumber < 0 ^ secondNumber < 0 ^ thirdNumber < 0)
        {
            Console.WriteLine("The sign of the product is '-'");
        }
        else
        {
            Console.WriteLine("The sign of the product is '+'");
        }
    }
}
