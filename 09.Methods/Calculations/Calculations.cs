using System;

class Calculations
{
    static int MinimumOfSet(params int[] setOfNumbers) //In this method we use varianble numbr of parameters
    {
        int minValue = setOfNumbers[0];
        for (int i = 0; i < setOfNumbers.Length; i++)
        {
            if (setOfNumbers[i] < minValue)
            {
                minValue = setOfNumbers[i];
            }
        }
        return minValue;
    }

    static int MaximumOfSet(params int[] setOfNumbers) //In this method we use varianble numbr of parameters
    {
        int Maxvalue = setOfNumbers[0];
        for (int i = 0; i < setOfNumbers.Length; i++)
        {
            if (setOfNumbers[i] > Maxvalue)
            {
                Maxvalue = setOfNumbers[i];
            }
        }
        return Maxvalue;
    }

    static double AvarageOfSet(params double[] setOfNumbers) //In this method we use varianble numbr of parameters
    {
        double result = 0;
        for (int i = 0; i < setOfNumbers.Length; i++)
        {
            result += setOfNumbers[i];
        }
        result = result / setOfNumbers.Length;
        return result;
    }

    static int SumOfSet(params int[] setOfNumbers) //In this method we use varianble numbr of parameters
    {
        int result = 0;
        for (int i = 0; i < setOfNumbers.Length; i++)
        {
            result += setOfNumbers[i];
        }
        return result;
    }

    static int ProductOfSet(params int[] setOfNumbers) //In this method we use varianble numbr of parameters
    {
        int result = 1;
        for (int i = 0; i < setOfNumbers.Length; i++)
        {
            result *= setOfNumbers[i];
        }
        return result;
    }

    static void Main()
    {
        Console.WriteLine("Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.");
        Console.WriteLine();
        Console.WriteLine("This is our set of numbers: 5, 10, 18, -3, 4, 9, 1, 6, -4");
        int minimum = MinimumOfSet(5, 10, 18, -3, 4, 9, 1, 6, -4);
        Console.WriteLine("Maximum: {0}." , MinimumOfSet(5, 10, 18, -3, 4, 9, 1, 6, -4)); //Calling method
        int maximum = MaximumOfSet(5, 10, 18, -3, 4, 9, 1, 6, -4);
        Console.WriteLine("Minimum: {0}.", MaximumOfSet(5, 10, 18, -3, 4, 9, 1, 6, -4)); //Calling method
        double avarage = AvarageOfSet(5, 10, 18, -3, 4, 9, 1, 6, -4);
        Console.WriteLine("Avarage: {0}", AvarageOfSet(5, 10, 18, -3, 4, 9, 1, 6, -4)); //Calling method
        int sum = SumOfSet(5, 10, 18, -3, 4, 9, 1, 6, -4);
        Console.WriteLine("Sum: {0}", SumOfSet(5, 10, 18, -3, 4, 9, 1, 6, -4)); //Calling method
        int product = ProductOfSet(5, 10, 18, -3, 4, 9, 1, 6, -4);
        Console.WriteLine("Product: {0}", ProductOfSet(5, 10, 18, -3, 4, 9, 1, 6, -4)); //Calling method
    }
}
