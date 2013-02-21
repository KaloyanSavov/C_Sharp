using System;
using System.Collections.Generic;

class DecimalToHexadecimalConversion
{
    static void Main()
    {
        Console.WriteLine("Write a program to convert decimal numbers to their hexadecimal representation.");
        Console.WriteLine();
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        List<string> hexadecimalNumber = new List<string>();
        int tempNumber = 0;
        string[] hex = { "A", "B", "C", "D", "E", "F" };
        do
        {
            tempNumber = number % 16;
            if (tempNumber >= 0 && tempNumber <= 9)
            {
                hexadecimalNumber.Add(tempNumber.ToString());
            }
            else
            {
                switch (tempNumber)
                {
                    case 10: hexadecimalNumber.Add(hex[0]); break;
                    case 11: hexadecimalNumber.Add(hex[1]); break;
                    case 12: hexadecimalNumber.Add(hex[2]); break;
                    case 13: hexadecimalNumber.Add(hex[3]); break;
                    case 14: hexadecimalNumber.Add(hex[4]); break;
                    case 15: hexadecimalNumber.Add(hex[5]); break;
                    default:
                        break;
                }

            }
            number = number / 16;
        } while (number > 0);
        for (int i = 0; i < hexadecimalNumber.Count; i++)
        {
            Console.Write(hexadecimalNumber[i]);
        }
        Console.WriteLine();
    }
}
