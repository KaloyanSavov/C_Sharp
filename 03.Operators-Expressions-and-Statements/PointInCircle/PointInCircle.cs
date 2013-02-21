using System;

class PointInCircle
{
    static void Main()
    {
        double radius = 5;
        double area = Math.PI * Math.Sqrt(radius);
        Console.WriteLine("Enter a value for 'x': ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a value for 'y': ");
        double y = double.Parse(Console.ReadLine());
        if ((x * x + y * y) <= radius * radius)
        {
            Console.WriteLine("The point is inside the Circle");
        }
        else
        {
            Console.WriteLine("The point is outside the Circle");
        }
    }
}
