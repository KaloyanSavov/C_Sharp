using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Enter one Number:");
        int number = int.Parse(Console.ReadLine());
        int reminder = number % 2;
        if (reminder == 0)
        {
            Console.WriteLine("The number is even");
        }
        else
        {
            Console.WriteLine("The number is odd");
        }
    }
}
