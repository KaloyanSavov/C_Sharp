using System;

class ModifyBit
{
    static void Main()
    {
        Console.WriteLine("Enter one number number: ");
        int number = int.Parse(Console.ReadLine());
        string binRepresentation = Convert.ToString(number, 2).PadLeft(8, '0');
        Console.WriteLine(binRepresentation);
        Console.WriteLine("Enter a position of the bit to be modified: ");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a binary number (0 or 1): ");
        int bit = int.Parse(Console.ReadLine());
        int mask = 1 << position;
        int convertedNumber = 0;
        if (bit == 1)
        {
            convertedNumber = number | mask;
        }
        else
        {
            convertedNumber = number ^ mask;
        }
        Console.WriteLine("New number: {0}" + convertedNumber);
    }
}

