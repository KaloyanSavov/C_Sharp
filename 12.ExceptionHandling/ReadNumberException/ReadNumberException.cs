using System;

class ReadNumberException
{
    static void ReadNumber(int start, int end)
    {
        int[] array = new int[10];
        Console.WriteLine("Enter ten numbers");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
            if (array[i] < start || array[i] > end)
            {
                throw new System.ArgumentOutOfRangeException();
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    static void Main()
    {
        Console.WriteLine("Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. If an invalid number or non-number text is entered, the method should throw an exception. Using this method write a program that enters 10 numbers:");
        Console.WriteLine("a1, a2, … a10, such that 1 < a1 < … < a10 < 100");
        Console.WriteLine();
        try
        {
            Console.WriteLine("Enter a start value:");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a end value:");
            int end = int.Parse(Console.ReadLine());
            ReadNumber(start, end);
        }
        catch (System.ArgumentOutOfRangeException)
        {

            Console.WriteLine("The number is out of range.");
        }
        catch (System.FormatException)
        {
            Console.WriteLine("You must enter a number!");
        }
    }
}
