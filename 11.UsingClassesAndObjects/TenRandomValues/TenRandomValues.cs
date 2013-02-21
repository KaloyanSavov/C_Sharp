using System;

class TenRandomValues
{
    static void Main()
    {
        Console.WriteLine("Write a program that generates and prints to the console 10 random values in the range [100, 200].");
        Console.WriteLine();
        Random randonNumbers = new Random();
        for (int i = 1; i <= 10; i++)
        {
            int number = randonNumbers.Next(100 , 200);
            Console.WriteLine(number);
        }
    }
}
