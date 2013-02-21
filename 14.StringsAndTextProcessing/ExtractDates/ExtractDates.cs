using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

class ExtractDates
{
    static void Main()
    {
        Console.WriteLine("Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. Display them in the standard date format for Canada.");
        Console.WriteLine();
        Console.WriteLine("This is out text");
        Console.WriteLine("We have text with a lot of dates. The dates are: 12.12.2012 , 1.1.2002 , 12.12.2022 , 04.05.2008 , 15.10.2009.");
        string text = "We have text with a lot of dates. The dates are: 12.12.2012 , 1.1.2002 , 12.12.2022 , 04.05.2008 , 15.10.2009";
        foreach (Match date in Regex.Matches(text, @"\b\d{2}.\d{2}.\d{4}\b"))
        {
            string stringExtract = Convert.ToString(date);
            DateTime exactDate = DateTime.ParseExact(stringExtract, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(exactDate.ToString(CultureInfo.GetCultureInfo("en-CA")));
        }
    }
}
