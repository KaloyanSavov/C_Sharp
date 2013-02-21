using System;

class ValueOfBit
{
    static void Main()
    {
        Console.WriteLine("Enter a numner to check:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a bit position to checked");
        int position = int.Parse(Console.ReadLine());
        int check = 1;
        int mask = check << position;
        Console.WriteLine((mask & number) != 0 ? 1 : 0);
    }
}
