using System;

class CheckThirdDigit
{
    static void Main()
    {
        Console.WriteLine("Enter a number to check (minimum 3 digits)");
        int number = int.Parse(Console.ReadLine());
        number /= 100;
        number %= 10;
        if (number == 7)
        {
            Console.WriteLine("The third digit from right to left is 7");
        }
        else
        {
            Console.WriteLine("The third digit from right to left is not 7");
        }
    }
}
