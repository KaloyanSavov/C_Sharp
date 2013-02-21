using System;

class ReadRadiusOfCircle
{
    static void Main()
    {
        Console.WriteLine("Enter the radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());
        double area = Math.PI * radius * radius;
        double perimeter = 2 * Math.PI * radius;
        Console.WriteLine("Perimeter is equal to: {0}", perimeter);
        Console.WriteLine("Area is equal to: {0}", area);
    }
}
