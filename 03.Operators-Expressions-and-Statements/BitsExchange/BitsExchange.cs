using System;

class BitsExchange
{
    static void Main()
    {
        Console.WriteLine("Enter a number to be modified:");
        uint number = uint.Parse(Console.ReadLine());
        uint mask3 = (number & 1 << 3);
        uint bit3 = mask3 >> 3;
        uint mask4 = (number & 1 << 4);
        uint bit4 = mask4 >> 4;
        uint mask5 = (number & 1 << 5);
        uint bit5 = mask5 >> 5;
        uint mask24 = (number & 1 << 24);
        uint bit24 = mask24 >> 24;
        uint mask25 = (number & 1 << 25);
        uint bit25 = mask25 >> 25;
        uint mask26 = (number & 1 << 26);
        uint bit26 = mask26 >> 26;
        uint result;
        uint tempResult;
        if (bit3 == 0)
        {
            tempResult = number & ((uint)(1 << 24));
        }
        else
        {
            tempResult = number | 1 << 24;
        }
        result = tempResult;
        if (bit4 == 0)
        {
            tempResult = result & ~((uint)(1 << 25));
        }
        else
        {
            tempResult = result | 1 << 25;
        }
        result = tempResult;
        if (bit5 == 0)
        {
            tempResult = result & ~((uint)(1 << 26));
        }
        else
        {
            tempResult = result | 1 << 26;
        }
        result = tempResult;
        if (bit24 == 0)
        {
            tempResult = result & ~((uint)(1 << 3));
        }
        else
        {
            tempResult = result | 1 << 3;
        }
        result = tempResult;
        if (bit25 == 0)
        {
            tempResult = result & ~((uint)(1 << 4));
        }
        else
        {
            tempResult = result | 1 << 4;
        }
        result = tempResult;
        if (bit26 == 0)
        {
            tempResult = result & ~((uint)(1 << 5));
        }
        else
        {
            tempResult = result | 1 << 5;
        }
        result = tempResult;
        Console.WriteLine("Number before {0} , binary before {1}", number, Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("Number after {0} , binary after {1}", result, Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}