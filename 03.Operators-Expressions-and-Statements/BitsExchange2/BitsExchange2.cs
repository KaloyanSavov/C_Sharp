using System;

class BitsExchange2
{
    static void Main()
    {
        Console.WriteLine("Enter a number to be modified:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the first bit position of next three to be modified:");
        int firstPosition = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the first bit position of the next three to be switched:");
        int lastPosition = int.Parse(Console.ReadLine());
        int maskP = (number & 1 << firstPosition);
        int bitP = maskP >> firstPosition;
        int maskPPlusOne = (number & 1 << (firstPosition + 1));
        int bitPPlusOne = maskPPlusOne >> (firstPosition + 1);
        int maskPPlusTwo = (number & 1 << (firstPosition + 2));
        int bitPPlusTwo = maskPPlusTwo >> (firstPosition + 2);
        int maskPLast = (number & 1 << lastPosition);
        int bitPLast = maskPLast >> lastPosition;
        int maskPLastPlusOne = (number & 1 << (lastPosition + 1));
        int bitPLastPlusOne = maskPLastPlusOne >> (lastPosition + 1);
        int maskPLastPlusTwo = (number & 1 << (lastPosition + 2));
        int bitPLastPlusTwo = maskPLastPlusTwo >> (lastPosition + 2);
        int result;
        int tempResult;
        if (bitP == 0)
        {
            tempResult = number & ((int)(1 << lastPosition));
        }
        else
        {
            tempResult = number | 1 << lastPosition;
        }
        result = tempResult;
        if (bitPPlusOne == 0)
        {
            tempResult = result & ~((int)(1 << (lastPosition + 1)));
        }
        else
        {
            tempResult = result | 1 << (lastPosition + 1);
        }
        result = tempResult;
        if (bitPPlusTwo == 0)
        {
            tempResult = result & ~((int)(1 << (lastPosition + 2)));
        }
        else
        {
            tempResult = result | 1 << (lastPosition + 2);
        }
        result = tempResult;
        if (bitPLast == 0)
        {
            tempResult = result & ~((int)(1 << firstPosition));
        }
        else
        {
            tempResult = result | 1 << firstPosition;
        }
        result = tempResult;
        if (bitPLastPlusOne == 0)
        {
            tempResult = result & ~((int)(1 << (firstPosition + 1)));
        }
        else
        {
            tempResult = result | 1 << (firstPosition + 1);
        }
        result = tempResult;
        if (bitPLastPlusTwo == 0)
        {
            tempResult = result & ~((int)(1 << (firstPosition + 2)));
        }
        else
        {
            tempResult = result | 1 << (firstPosition + 2);
        }
        result = tempResult;
        Console.WriteLine("Number before {0} , binary before {1}", number, Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("Number after {0} , binary after {1}", result, Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}
