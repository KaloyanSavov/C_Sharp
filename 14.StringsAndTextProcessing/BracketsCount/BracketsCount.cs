using System;
using System.Text;

class BracketsCount
{
    static void Main()
    {
        Console.WriteLine("Write a program to check if in a given expression the brackets are put correctly.");
        Console.WriteLine("Example of correct expression: ((a+b)/5-d).");
        Console.WriteLine("Example of incorrect expression: )(a+b)).");
        Console.WriteLine();
        Console.WriteLine("Enter a expression:");
        string expression = Console.ReadLine();
        char[] array = expression.ToCharArray();
        int count = 0;
        if (array[0] == ')')
        {
            Console.WriteLine("Wrong Expression.");
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] == '(')
                {
                    count++;
                }
                else if (array[i] == ')')
                {
                    count--;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Correct Expression.");
            }
            else
            {
                Console.WriteLine("Incorrect Expression.");
            }
        }
    }
}
