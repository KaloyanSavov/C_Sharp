using System;

class LastDigitMethod
{
    static void LastDigit(int lastDigit) //This method gets the last number and writes to the console with words the last digit
    {
        switch (lastDigit)      //The variable is the last digit of the number
        {
            case 1: Console.WriteLine("One"); break;
            case 2: Console.WriteLine("Two"); break;
            case 3: Console.WriteLine("Three"); break;
            case 4: Console.WriteLine("Four"); break;
            case 5: Console.WriteLine("Five"); break;
            case 6: Console.WriteLine("Six"); break;
            case 7: Console.WriteLine("Seven"); break;
            case 8: Console.WriteLine("Eight"); break;
            case 9: Console.WriteLine("Nine"); break;
            case 0: Console.WriteLine("Zero"); break;
            default:
                break;
        }
    }
    static void Main()
    {
        Console.WriteLine("Write a method that returns the last digit of given integer as an English word.");
        Console.WriteLine("Examples: 512 -> two , 1024 -> four , 12309 -> nine .");
        Console.WriteLine();
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int lastDigit = number % 10;  // Gets the last number
        LastDigit(lastDigit);   //Calling Method
    }
}
