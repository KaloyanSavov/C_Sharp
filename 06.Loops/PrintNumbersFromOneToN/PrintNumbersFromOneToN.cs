using System;

class PrintNumbersFromOneToN
{
    static void Main()
    {
        Console.WriteLine("Enter one number");
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}