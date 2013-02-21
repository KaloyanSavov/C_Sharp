using System;

class CopyrightSymbol
{
    static void Main()
    {
        int copyrightSymbol = 0x00a9;
        char symbol = (char)copyrightSymbol;
        Console.WriteLine("  {0}", symbol);
        Console.WriteLine(" {0}{0}{0}", symbol);
        Console.WriteLine("{0}{0}{0}{0}{0}", symbol);
    }
}
