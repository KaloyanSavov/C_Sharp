using System;
using System.Collections.Generic;

class HexadecimalToBinaryConversion
{
    static void Main()
    {
        Console.WriteLine("Write a program to convert hexadecimal numbers to their decimal representation.");
        Console.WriteLine();
        Console.WriteLine("Enter a hexadecimal number:");
        string hexadecimalNumber = Console.ReadLine();
        char[] array = hexadecimalNumber.ToCharArray();
        List<string> binarylNumber = new List<string>();
        for (int i = 0; i < array.Length; i++)
        {
            switch (array[i])
            {
                case '1': binarylNumber.Add("0001"); break;
                case '2': binarylNumber.Add("0010"); break;
                case '3': binarylNumber.Add("0011"); break;
                case '4': binarylNumber.Add("0100"); break;
                case '5': binarylNumber.Add("0101"); break;
                case '6': binarylNumber.Add("0110"); break;
                case '7': binarylNumber.Add("0111"); break;
                case '8': binarylNumber.Add("1000"); break;
                case '9': binarylNumber.Add("1001"); break;
                case '0': binarylNumber.Add("0000"); break;
                case 'A': binarylNumber.Add("1010"); break;
                case 'B': binarylNumber.Add("1011"); break;
                case 'C': binarylNumber.Add("1100"); break;
                case 'D': binarylNumber.Add("1101"); break;
                case 'E': binarylNumber.Add("1110"); break;
                case 'F': binarylNumber.Add("1111"); break;
                case 'a': binarylNumber.Add("1010"); break;
                case 'b': binarylNumber.Add("1011"); break;
                case 'c': binarylNumber.Add("1100"); break;
                case 'd': binarylNumber.Add("1101"); break;
                case 'e': binarylNumber.Add("1110"); break;
                case 'f': binarylNumber.Add("1111"); break;
                default:
                    break;
            }
        }

        for (int i = 0; i < binarylNumber.Count; i++)
        {
            Console.Write(binarylNumber[i]);
        }
        Console.WriteLine();
    }
}
