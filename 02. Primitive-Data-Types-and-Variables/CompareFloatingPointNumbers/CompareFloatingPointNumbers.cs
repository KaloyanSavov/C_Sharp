using System;

class CompareFloatingPointNumbers
{
    static void Main()
    {
        float a = 6.34f;
        float b = 7.21f;
        float c = 6.123456789f;
        float d = 6.12345678901f;
        bool compareFirst = (a == b);
        Console.WriteLine(compareFirst);
        bool compareSecond = (c == d);
        Console.WriteLine(compareSecond);
    }
}