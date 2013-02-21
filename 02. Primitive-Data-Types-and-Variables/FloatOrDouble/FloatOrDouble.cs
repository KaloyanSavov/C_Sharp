using System;

class FloatOrDouble
{
    static void Main()
    {
        double firstValue = 34.567839023;
        float secondValue = 12.345f;
        double thirdValue = 8923.1234857;
        float fourthValue = 3456.091f;
        Console.WriteLine("float: {0} {1} " , secondValue , fourthValue);
        Console.WriteLine("double: {0} {1}" , firstValue , thirdValue);
    }
}