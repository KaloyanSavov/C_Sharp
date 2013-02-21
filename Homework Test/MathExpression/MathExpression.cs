using System;

class MathExpression
{
    static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());
        decimal m = decimal.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());
        decimal sin = (decimal)Math.Sin((int)m % 180);
        decimal result = (((n * n) + (1 / (m * p)) + 1337) / (n - 128.523123123M * p)) + sin;
        Console.WriteLine(String.Format("{0:F6}", result));
    }
}
