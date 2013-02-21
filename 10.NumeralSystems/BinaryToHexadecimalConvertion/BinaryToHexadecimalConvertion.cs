using System;
using System.Text;

class BinaryToHexadecimalConvertion
{
    static void Main()
    {
        Console.WriteLine("Write a program to convert binary numbers to hexadecimal numbers (directly).");
        Console.WriteLine();
        Console.WriteLine("Enter a binary number:");
        string number = Console.ReadLine();
        if ((number.Length % 4) != 0)
        {
            number = new String('0', 4 - (number.Length % 4)) + number;
        }
        for (int i = 0; i < number.Length; i = i + 4)
        {
            switch (number.Substring( i , 4))
            {
                case "1010": Console.Write("A"); break;
                case "1011": Console.Write("B"); break;
                case "1100": Console.Write("C"); break;
                case "1101": Console.Write("D"); break;
                case "1110": Console.Write("E"); break;
                case "1111": Console.Write("F"); break;
                case "0000": Console.Write("0"); break;
                case "0001": Console.Write("1"); break;
                case "0010": Console.Write("2"); break;
                case "0011": Console.Write("3"); break;
                case "0100": Console.Write("4"); break;
                case "0101": Console.Write("5"); break;
                case "0110": Console.Write("6"); break;
                case "0111": Console.Write("7"); break;
                case "1000": Console.Write("8"); break;
                case "1001": Console.Write("9"); break;
                default:
                    break;
            }
        }
        Console.WriteLine();
    }
}
