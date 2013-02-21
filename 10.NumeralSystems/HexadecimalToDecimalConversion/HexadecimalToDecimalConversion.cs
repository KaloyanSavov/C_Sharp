using System;

class HexadecimalToDecimalConversion
{
    static void Main()
    {
        Console.WriteLine("Write a program to convert hexadecimal numbers to their decimal representation.");
        Console.WriteLine();
        Console.WriteLine("Enter a hexadecimal number:");
        string hexadecimalNumber = Console.ReadLine();
        char[] array = hexadecimalNumber.ToCharArray();
        int decimalNumber = 0;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            switch (array[i])
            {
                case '1': decimalNumber = decimalNumber + (1 * (int)Math.Pow(16, i)); break;
                case '2': decimalNumber = decimalNumber + (2 * (int)Math.Pow(16, i)); break;
                case '3': decimalNumber = decimalNumber + (3 * (int)Math.Pow(16, i)); break;
                case '4': decimalNumber = decimalNumber + (4 * (int)Math.Pow(16, i)); break;
                case '5': decimalNumber = decimalNumber + (5 * (int)Math.Pow(16, i)); break;
                case '6': decimalNumber = decimalNumber + (6 * (int)Math.Pow(16, i)); break;
                case '7': decimalNumber = decimalNumber + (7 * (int)Math.Pow(16, i)); break;
                case '8': decimalNumber = decimalNumber + (8 * (int)Math.Pow(16, i)); break;
                case '9': decimalNumber = decimalNumber + (9 * (int)Math.Pow(16, i)); break;
                case '0': decimalNumber = decimalNumber + (0 * (int)Math.Pow(16, i)); break;
                case 'A': decimalNumber = decimalNumber + (10 * (int)Math.Pow(16, i)); break;
                case 'B': decimalNumber = decimalNumber + (11 * (int)Math.Pow(16, i)); break;
                case 'C': decimalNumber = decimalNumber + (12 * (int)Math.Pow(16, i)); break;
                case 'D': decimalNumber = decimalNumber + (13 * (int)Math.Pow(16, i)); break;
                case 'E': decimalNumber = decimalNumber + (14 * (int)Math.Pow(16, i)); break;
                case 'F': decimalNumber = decimalNumber + (15 * (int)Math.Pow(16, i)); break;
                case 'a': decimalNumber = decimalNumber + (10 * (int)Math.Pow(16, i)); break;
                case 'b': decimalNumber = decimalNumber + (11 * (int)Math.Pow(16, i)); break;
                case 'c': decimalNumber = decimalNumber + (12 * (int)Math.Pow(16, i)); break;
                case 'd': decimalNumber = decimalNumber + (13 * (int)Math.Pow(16, i)); break;
                case 'e': decimalNumber = decimalNumber + (14 * (int)Math.Pow(16, i)); break;
                case 'f': decimalNumber = decimalNumber + (15 * (int)Math.Pow(16, i)); break;

                default:
                    break;
            }
        }
        Console.WriteLine(decimalNumber);
    }
}
