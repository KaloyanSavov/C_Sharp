using System;

class AsciiCharacters
{
    static void Main()
    {
        int characters = 126;
        for (int i = 0; i <= characters; i++)
        {

            Console.Write((char)i);
        }
        Console.WriteLine();
    }
}
