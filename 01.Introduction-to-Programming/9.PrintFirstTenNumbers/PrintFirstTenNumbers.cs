using System;

class PrintFirstTenNumbers
{
    static void Main()
    {
        int plus = 2;
        int minus = -3;

        Console.Write(plus + ", " + minus);

        for (int i = 0; i < 4; i++)
        {
            plus += 2;
            minus -= 2;
            Console.Write(", " + plus + ", " + minus);
        }

        Console.WriteLine();
    }
}