using System;

class DayOfTheWeekToday
{
    static void Main()
    {
        Console.WriteLine("Write a program that prints to the console which day of the week is today. Use System.DateTime.");
        Console.WriteLine();
        Console.WriteLine("Today is {0}." , DateTime.Today.DayOfWeek);
    }
}
