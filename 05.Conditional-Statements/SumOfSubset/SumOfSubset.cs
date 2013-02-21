using System;

class SumOfSubset
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third number:");
        int thirdNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the fourth number:");
        int fourthNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the fifth number: ");
        int fifthNumber = int.Parse(Console.ReadLine());
        if (firstNumber + secondNumber + thirdNumber == 0 | firstNumber + secondNumber + fourthNumber == 0 | firstNumber + secondNumber + fifthNumber == 0)
        {
            Console.WriteLine("The sum of some subset is equal to zero");
        }
        else if (firstNumber + thirdNumber + fourthNumber == 0 | firstNumber + thirdNumber + fifthNumber == 0 | firstNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("The sum of some subset is equal to zero");
        }
        else if (secondNumber + thirdNumber + fourthNumber == 0 | secondNumber + thirdNumber + fifthNumber == 0 | secondNumber + fourthNumber + fifthNumber == 0 | thirdNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("The sum of some subset is equal to zero");
        }
        else
        {
            Console.WriteLine("There is no sum of subset equal to zero.");
        }
    }
}