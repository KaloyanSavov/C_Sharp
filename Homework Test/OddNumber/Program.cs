using System;

class OddNumber
{
    static void Main()
    {
        long n = int.Parse(Console.ReadLine());
        long oddNumber = 0;
        for (int i = 0; i < n; i++)
        {
            long inputNumber = long.Parse(Console.ReadLine());
            oddNumber = oddNumber ^ inputNumber;
        }
        Console.WriteLine(oddNumber);
    }
}
