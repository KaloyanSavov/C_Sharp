using System;

class TwoVariablesExchage
{
    static void Main()
    {
        Console.WriteLine("a=5");
        Console.WriteLine("b=10");
        int a = 5;
        int b = 10;
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine("a= {0}", a);
        Console.WriteLine("b= {0}", b);
    }
}
