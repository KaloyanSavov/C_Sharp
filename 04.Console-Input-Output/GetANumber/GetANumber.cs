using System;

class GetANumber
{
    static void Main()
    {
        Console.WriteLine("Enter one number:");
        int number = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("Enter a value:");
            sum += int.Parse(Console.ReadLine());

        }
        Console.WriteLine("The sum is: {0}", sum);
    }
}
