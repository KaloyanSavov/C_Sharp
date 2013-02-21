using System;

class TrapezoidsArea
{
    static void Main()
    {
        Console.WriteLine("Enter a number for side 'a': ");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number for side 'b'");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number for the height 'h'");
        float h = float.Parse(Console.ReadLine());
        float area = ((a + b) * h) / 2;
        Console.WriteLine("The area is equal to: {0}", area);
    }
}
