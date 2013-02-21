using System;

class PrimeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter a number between 1 and 100: ");
        byte number = byte.Parse(Console.ReadLine());
        if (number == 2 | number == 3 | number == 5 | number == 7 | number == 11 | number == 13 | number == 17 | number == 19 | number == 23 | number == 29 | number == 31 | number == 37 | number == 41 | number == 43 | number == 47 | number == 53 | number == 59 | number == 61 | number == 67 | number == 71 | number == 73 | number == 79 | number == 83 | number == 89 | number == 97)
        {
            Console.WriteLine("The number is prime");
        }
        else
        {
            Console.WriteLine("The number is not prime");
        }
    }
}
