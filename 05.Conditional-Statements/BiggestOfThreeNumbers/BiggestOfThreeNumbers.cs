using System;

class BiggestOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        if (firstNumber > secondNumber & firstNumber > thirdNumber)
        {
            Console.WriteLine("The biggest number is: {0}", firstNumber);
        }
        else
        {
            if (firstNumber < secondNumber & secondNumber > thirdNumber)
            {
                Console.WriteLine("The biggest number is: {0}", secondNumber);
            }
            else
            {
                Console.WriteLine("The biggest number is: {0}", thirdNumber);
            }
        }
    }
}
