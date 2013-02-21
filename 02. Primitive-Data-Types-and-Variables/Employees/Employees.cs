using System;

class Employees
{
    static void Main()
    {
        Console.WriteLine("Employee first name");
        string firstName = Console.ReadLine();
        Console.WriteLine("Employee family name");
        string familyName = Console.ReadLine();
        Console.WriteLine("Employee age:");
        byte age = byte.Parse(Console.ReadLine());
        Console.WriteLine("Employee gendder(f or m)");
        string gender = Console.ReadLine();
        Console.WriteLine("Employee ID Number");
        long idNumber = long.Parse(Console.ReadLine());
        Console.WriteLine("Unique employee number(27560000 to 27569999)");
        int employeeUniqueNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Employee full details:");
        Console.WriteLine("First Name: {0}", firstName);
        Console.WriteLine("Family Name: {0}", familyName);
        Console.WriteLine("Age: {0}", age);
        if (gender == "m")
        {
            Console.WriteLine("Gender: Male");
        }
        else if (gender == "f")
        {
            Console.WriteLine("Gender: Female");
        }
        else
        {
            Console.WriteLine("Wrong symbol");
        }
        Console.WriteLine("ID Nymber: {0}", idNumber);
        if (employeeUniqueNumber < 27560000)
        {
            Console.WriteLine("Wrong Number");
        }
        else if (employeeUniqueNumber > 27569999)
        {
            Console.WriteLine("Wrong Number");
        }
        else
        {
            Console.WriteLine("Employee Unique Number: {0}", employeeUniqueNumber);
        }
    }
}