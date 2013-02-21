using System;

class CalculateSum
{
    static void Main()
    {
        decimal sum = 1m;
        decimal previousSum = 1m;
        decimal counter = 2m;
        do
        {
            previousSum = sum;
            if (counter % 2 == 0)
            {
                sum += (decimal)1 / counter;
            }
            else
            {
                sum -= (decimal)1 / counter;
            }
            counter++;
        } while (Math.Abs(sum - previousSum) >= (decimal)0.001m);
        Console.WriteLine("{0:0.000}", sum);
    }
}