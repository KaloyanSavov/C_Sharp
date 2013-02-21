using System;

class PrintMyAgeAfterTenYears
{
    static void Main()
    {
        Console.WriteLine("Please enter your age (1 to 130 Years)");
        int age = int.Parse(Console.ReadLine());
        int result = age + 10;
        if (age > 130)
        {
            Console.WriteLine("You are too old. Try again. ;)");
        }
        if (age < 1)
        {
            Console.WriteLine("Wrong age. Try again.");
        }
        else
        {
            Console.WriteLine("Your age after 10 years will be: " + result + " years");
        }
    }
}