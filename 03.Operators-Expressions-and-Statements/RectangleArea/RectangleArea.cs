using System;

class RectangleArea
{
    static void Main()
    {
        Console.WriteLine("Enter the width of the rectangle:");
        float width = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height of the rectangle");
        float height = float.Parse(Console.ReadLine());
        float area = width * height;
        Console.WriteLine("Area = {0}", area);
    }
}
