using System;

class PrintName
{
    static void PrintMyName() //Method that print a name on the console
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}", name);
    }

    static void Main()
    {
        Console.WriteLine("Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). Write a program to test this method.");
        Console.WriteLine();
        PrintMyName(); // Calling Method
    }
}
