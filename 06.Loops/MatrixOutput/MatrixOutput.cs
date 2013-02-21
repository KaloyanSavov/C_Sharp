using System;

class MatrixOutput
{
    static void Main()
    {
        Console.WriteLine("Enter one number between 1 and 20: ");
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(" ");
            for (int j = i; j <= number - 1 + i; j++)
            {
                Console.Write(" " + j + " ");
            }
        }
    }
}