using System;
using System.Text;
using System.Globalization;

class DateInBulgarian
{
    static void Main()
    {
        Console.WriteLine("Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.");
        Console.WriteLine();
        try
        {
            Console.WriteLine("Enter a date in format dd.MM.yyyy HH:mm:ss");
            string date = Console.ReadLine();
            DateTime dateOne = DateTime.ParseExact(date, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            dateOne = dateOne.AddHours(6.5);
            Console.WriteLine("New Date:");
            Console.WriteLine("{0} {1}", dateOne.ToString("dddd", new CultureInfo("bg-BG")), dateOne);
        }
        catch (FormatException)
        {

            Console.WriteLine("Wrong Format");
        }
    }
}
