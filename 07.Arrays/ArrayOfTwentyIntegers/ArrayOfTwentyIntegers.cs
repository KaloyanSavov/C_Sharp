using System;

class ArrayOfTwentyIntegers
{
    static void Main()
    {
        Console.WriteLine("Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.");
        Console.WriteLine();
        Console.WriteLine("Enter twenty int numbers to fill the array");
        int[] array = new int[20];
        for (int i = 0; i < 20; i++)    //This cycle fills the values of the elements for the array
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        for (int index = 0; index < array.Length; index++)  //With this cycle we will multiply every element with five ana print in on the console
        {
            array[index] = array[index] * 5;
            Console.WriteLine(array[index]);
        }
    }
}
