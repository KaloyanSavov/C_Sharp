using System;

class SurfaceOfTheTriangle
{
    static void ThreeSides(double firstSide, double secondSide, double thirdSide)
    {
        double halfPerimeter = (firstSide + secondSide + thirdSide)/2;
        double area = Math.Sqrt(halfPerimeter * (halfPerimeter - firstSide)*(halfPerimeter - secondSide)*(halfPerimeter - thirdSide));
        Console.WriteLine("Area is equal to {0}." , area);
    }
    static void SideAndAltitude(double firstSide, double altitude)
    {
        double area = (firstSide * altitude) / 2;
        Console.WriteLine("Area is equal to {0}.", area);
    }
    static void TwoSidesAndAngle(double firstSide, double secondSide, double angle)
    {
        double area = (firstSide * secondSide * Math.Sin((angle * Math.PI) / 180)) ;
        Console.WriteLine("Area is equal to {0}.", area);
    }
    static void Main()
    {
        Console.WriteLine("Write methods that calculate the surface of a triangle by given:");
        Console.WriteLine("Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math");
        Console.WriteLine();
        Console.WriteLine("Enter the method for calculating the area of triangle");
        Console.WriteLine("1. By three sides.");
        Console.WriteLine("2. Side and an altitude to it.");
        Console.WriteLine("3. Two sides and an angle between them.");
        double choise = double.Parse(Console.ReadLine());
        if (choise == 1)
        {
            Console.WriteLine("Enter the three sides of the triangle(a , b , c):");
            double firstSide = double.Parse(Console.ReadLine());
            double secondSide = double.Parse(Console.ReadLine());
            double thirdSide = double.Parse(Console.ReadLine());
            ThreeSides(firstSide, secondSide, thirdSide);
        }
        else if (choise == 2)
        {
            Console.WriteLine("Enter the value for side 'a':");
            double firstSide = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the altitude to side 'a':");
            double altitude = double.Parse(Console.ReadLine());
            SideAndAltitude(firstSide, altitude);
        }
        else if (choise == 3)
        {
            Console.WriteLine("Enter bthe values for side 'a' and side 'b':");
            double firstSide = double.Parse(Console.ReadLine());
            double secondSide = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the angle between 'a' and 'b' in degrees:");
            double angle = double.Parse(Console.ReadLine());
            TwoSidesAndAngle(firstSide, secondSide, angle);
        }
        else
        {
            Console.WriteLine("Wrong choise");
        }
    }
}
