using System;

class ReverseDigitsMethod
{
    static void ReverseDigits(decimal number) //This method convers the number to string
    {
        string numberConvert = number.ToString();
        char[] array = numberConvert.ToCharArray(); //We create a char array and converts the sting
        for (int i = array.Length - 1; i >= 0; i--) //Write the digits in reverse order
			{
			    Console.Write(array[i]);
			}
        Console.WriteLine();
    }

    static void Main()
    {
        Console.WriteLine("Write a method that reverses the digits of given decimal number.");
        Console.WriteLine("Example: 256 -> 652");
        Console.WriteLine();
        Console.WriteLine("Enter a number:");
        decimal number = decimal.Parse(Console.ReadLine());
        ReverseDigits(number); //Calling method
    }
}
