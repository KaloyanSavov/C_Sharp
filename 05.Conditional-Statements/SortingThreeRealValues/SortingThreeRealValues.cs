using System;

class SortingThreeRealValues
{
    static void Main()
    {                                                                           
        Console.WriteLine("Enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        if (firstNumber < secondNumber)
        {
            if (secondNumber < thirdNumber)
            {
                Console.WriteLine("The order of the numbers is: {0} {1} {2}", firstNumber, secondNumber, thirdNumber);
            }
            else
            {
                if (firstNumber > thirdNumber)
                {
                    Console.WriteLine("The order of the numbers is: {0} {1} {2}", thirdNumber, firstNumber, secondNumber);
                }
                else
                {
                    Console.WriteLine("The order of the numbers is: {0} {1} {2}", firstNumber, thirdNumber, secondNumber);
                }
            }
        }
        if (firstNumber > secondNumber)
        {
            if (secondNumber > thirdNumber)
            {
                Console.WriteLine("The order of the numbers is: {0} {1} {2}", thirdNumber, secondNumber, firstNumber);
            }
            else
            {
                if (firstNumber > thirdNumber)
                {
                    Console.WriteLine("The order of the numbers is: {0} {1} {2}", secondNumber, thirdNumber, firstNumber);
                }
                else
                {
                    Console.WriteLine("The order of the numbers is: {0} {1} {2}", secondNumber, firstNumber, thirdNumber);
                }
            }
        }
    }
}