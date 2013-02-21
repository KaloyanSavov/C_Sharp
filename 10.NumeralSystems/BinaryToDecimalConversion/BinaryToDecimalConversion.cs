using System;
using System.Collections.Generic;

    class BinaryToDecimalConversion
    {
        static void Main()
        {
            Console.WriteLine("Write a program to convert binary numbers to their decimal representation.");
            Console.WriteLine();
            Console.WriteLine("Enter a binary number:");
            int binaryNumber = int.Parse(Console.ReadLine());
            List<int> binaryList = new List<int>();
            int decimalNumber = 0;
            do
            {
                binaryList.Add(binaryNumber % 10);
                binaryNumber = binaryNumber /10;
            } while (binaryNumber > 0);
            for (int i = binaryList.Count - 1; i >= 0; i--)
            {
                decimalNumber = decimalNumber + (binaryList[i]*(int)Math.Pow(2 , i));
            }
            Console.WriteLine(decimalNumber);
        }
    }
