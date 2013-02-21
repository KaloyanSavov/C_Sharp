using System;

class DivideByFiveAndSeven
{
    static void Main()
    {
        Console.WriteLine("Enter one number:");
        int number = int.Parse(Console.ReadLine());
        int fiveReminder = number % 5;
        int sevenReminder = number % 7;
        if (fiveReminder == 0 && sevenReminder == 0)
        {
            Console.WriteLine("The number can be divided to 5 and to 7 at the same time");
        }
        else
        {
            Console.WriteLine("The number can't be divided to 5 and to 7 at the same time");
        }
    }
}
