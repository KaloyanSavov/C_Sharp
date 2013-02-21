using System;

class FibonacciSequence
{
    static void Main()
    {
        int number1 = 0;
        int number2 = 1;
        int sum = 1;
        while (number1 < 600)
        {
            sum = number1 + number2;
            number1 = number2;
            number2 = sum;
            Console.WriteLine(number2);
        }
    }
}
