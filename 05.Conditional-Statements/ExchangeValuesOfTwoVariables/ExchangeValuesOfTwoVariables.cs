using System;

class ExchangeValuesOfTwoVariables
{
    static void Main()
    {
        Console.WriteLine("Enter a value for for the first variable: ");
        int firstValue = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a value for the second variable:");
        int secondValue = int.Parse(Console.ReadLine());
        int maxValue = firstValue;
        if (firstValue > secondValue)
        {
            firstValue = secondValue;
            secondValue = maxValue;
            Console.WriteLine("First variable is equal to {0} and second variable is equal to {1}", firstValue, secondValue);
        }
        else if (firstValue == secondValue)
        {
            Console.WriteLine("The values are equal");
        }
        else
        {
            Console.WriteLine("Second value is bigger than first value");
        }
    }
}
