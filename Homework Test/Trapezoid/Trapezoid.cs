using System;

class Trapezoid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n * 2; i++)
        {
            if (i <= n)
            {
                Console.Write('.');
            }
            else
            {
                Console.Write('*');
            }
        }
        Console.WriteLine();
        for (int i = n; i >= 2; i--)
        {
            for (int j = 1, k = n; j <= n; j++)
            {
                if (i == j)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }
            for (int j = n + 1, k = n * 2; j <= n * 2; j++)
            {
                if (j >= n + 1 && j <= n * 2 - 1)
                {
                    Console.Write('.');
                }
                else
                {
                    Console.Write('*');
                }
            }
            Console.WriteLine();
        }
        for (int i = 1; i <= n * 2; i++)
        {
            Console.Write('*');
        }
        Console.WriteLine();
    }
}
