using System;

class LeapYear
{
    static void Main()
    {
        Console.WriteLine("Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.");
        Console.WriteLine();
        Console.WriteLine("Enter the year that you want to check:");
        int year = int.Parse(Console.ReadLine());
        if (DateTime.IsLeapYear(year) == true)
        {
            Console.WriteLine("The year is leap");
        }
        else
        {
            Console.WriteLine("The year is not leap");
        }
    }
}
