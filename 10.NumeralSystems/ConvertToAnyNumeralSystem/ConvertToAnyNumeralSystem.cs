using System;
using System.Collections.Generic;

class ConvertToAnyNumeralSystem
{
    static int ConvertToDecimal(int s, string number)
    {
        int decimalNumber = 0;
        int newNumber = int.Parse(number);
        if (s < 10)
        {
            List<int> numeralSystemList = new List<int>();
            do
            {
                numeralSystemList.Add(newNumber % 10);
                newNumber = newNumber / 10;
            } while (newNumber > 0);
            for (int i = numeralSystemList.Count - 1; i >= 0; i--)
            {
                decimalNumber = decimalNumber + (numeralSystemList[i] * (int)Math.Pow(s, i));
            }
            return decimalNumber;
        }
        else
        {
            char[] array = number.ToCharArray();
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
                }
            }
            return decimalNumber;
        }
    }

    static void ConvertFromDecimal(int d, int decimalNumber)
    {

        if (d < 10)
        {
            List<int> newNumber = new List<int>();
            while (decimalNumber > 0)
            {
                if (decimalNumber % d == 0)
                {
                    newNumber.Add(0);
                }
                else
	            {
                    newNumber.Add(1);
	            }
                decimalNumber = decimalNumber / d;
            }
            newNumber.Reverse();
            for (int i = 0; i < newNumber.Count; i++)
            {
                Console.Write(newNumber[i]);
            }
            Console.WriteLine();
        }
        else
        {
            List<string> hexadecimalNumber = new List<string>();
            int tempNumber = 0;
            string[] hex = { "A", "B", "C", "D", "E", "F" };
            do
            {
                tempNumber = decimalNumber % d;
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
                decimalNumber = decimalNumber / d;
            } while (decimalNumber > 0);
            for (int i = 0; i < hexadecimalNumber.Count; i++)
            {
                Console.Write(hexadecimalNumber[i]);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.WriteLine("Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 <= s, d <=  16).");
        Console.WriteLine();
        Console.WriteLine("Enter the base S of the numeral system:");
        int s = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number with base S:");
        string number = Console.ReadLine();
        Console.WriteLine("Enter the base D of the numeral system:");
        int d = int.Parse(Console.ReadLine());
        ConvertFromDecimal(ConvertToDecimal(s, number), d);
    }
}
