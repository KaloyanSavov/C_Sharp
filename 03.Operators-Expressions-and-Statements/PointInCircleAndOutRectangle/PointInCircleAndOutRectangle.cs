using System;

class PointInCircleAndOutRectangle
{
    static void Main()
    {
        double r = 3;
        Console.WriteLine("Enter a value for 'x': ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a value for 'y': ");
        double y = double.Parse(Console.ReadLine());
        if ((((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= r * r) && !((x >= -1 && x <= 4) && (y <= 1 && y >= -1)))
        {
            Console.WriteLine("The point is inside the Circle and Outside Rectangle");
        }
        else
        {
            Console.WriteLine("The point is outside the Circle and Outside the Ractangle");
        }
    }
}
