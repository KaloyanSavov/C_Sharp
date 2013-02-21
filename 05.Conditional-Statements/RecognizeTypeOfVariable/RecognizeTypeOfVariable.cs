using System;

class RecognizeTypeOfVariable
{
    static void Main()
    {
        Console.WriteLine("Choose type of variable: int , double or string:");
        string variable = Console.ReadLine();
        Console.WriteLine("Enter a value for the variable");
        string value = Console.ReadLine();
        switch (variable)
        {
            case "int": Console.WriteLine(int.Parse(value) + 1); break;
            case "double": Console.WriteLine(double.Parse(value) + 1); break;
            case "string": Console.WriteLine(value + "*"); break;
            default: Console.WriteLine("Error"); break;
        }
    }
}
