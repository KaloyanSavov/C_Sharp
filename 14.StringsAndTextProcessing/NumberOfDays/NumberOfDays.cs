using System;
using System.Text;
using System.Globalization;

class NumberOfDays
{
    static void Main()
    {
        Console.WriteLine("Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. Example:");
        Console.WriteLine("Enter the first date: 27.02.2006");
        Console.WriteLine("Enter the second date: 3.03.2006");
        Console.WriteLine("Distance: 4 days");
        Console.WriteLine();
        Console.WriteLine("Enter the first date in format dd.MM.yyyy");
        string firstDate = Console.ReadLine();
        DateTime dateFirst = DateTime.ParseExact(firstDate, "d.MM.yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine("Enter the second date in format dd.MM.yyyy");
        string secondDate = Console.ReadLine();
        DateTime dateSecond = DateTime.ParseExact(secondDate, "d.MM.yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine("Number of days between the two dates:");
        Console.WriteLine((dateSecond - dateFirst).TotalDays);
    }
}
