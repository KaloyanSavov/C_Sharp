using System;
using System.Collections.Generic;

class DecimalToBinaryConversion
{
    static void Main()
    {
        Console.WriteLine("Write a program to convert decimal numbers to their binary representation.");
        Console.WriteLine();
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        List<int> binaryNumber = new List<int>();
        while (number > 0)
        {
            if (number % 2 == 0)
            {
                binaryNumber.Add(0);
            }
            else
	        {
                binaryNumber.Add(1);
	        }
            number = number / 2;
        }
        binaryNumber.Reverse();
        for (int i = 0; i < binaryNumber.Count; i++)
        {
            Console.Write(binaryNumber[i]);
        }
        Console.WriteLine();
    }
}
