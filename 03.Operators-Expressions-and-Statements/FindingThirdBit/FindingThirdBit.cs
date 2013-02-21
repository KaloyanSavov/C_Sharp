using System;

class FindingThirdBit
{
    static void Main()
    {
        Console.WriteLine("Enter one number: ");
        int number = int.Parse(Console.ReadLine());
        int bitMove = number >> 3;
        int reminder = bitMove % 2;
        if (reminder == 0)
        {
            Console.WriteLine("Third bit is 0");
        }
        else
        {
            Console.WriteLine("Third bit is 1");
        }
        //Second variant
        int mask = 1;
        mask <<= 3;
        if ((mask & number) > 0)
        {
            Console.WriteLine("Third bit is 1");
        }
        else
        {
            Console.WriteLine("Third bit is 0");
        }
    }
}
