using System;

class GetMaxMethod
{
    static int GetMax (int firstNumber , int secondNumber) //This method returns the biggest of the first two numbers
    {
        if (firstNumber >= secondNumber)
        {
            return firstNumber;
        }
        else
        {
            return secondNumber;
        }
    }
    static void Main()
    {
        Console.WriteLine("Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().");
        Console.WriteLine();
        Console.WriteLine("Enter the first number:");   //Entering numbers
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third Number:");
        int thirdNumber = int.Parse(Console.ReadLine());
        if (GetMax(firstNumber , secondNumber) > thirdNumber) // GetMax method returns result and the result is compared with the third number
        {
            Console.WriteLine("The biggest Number is: {0}" , GetMax(firstNumber , secondNumber)); //Print MaxNumber
        }
        else
        {
            Console.WriteLine("The biggest Number is: {0}", thirdNumber); //Print MaxNumber
        }

    }
}
