using System;

class CompareTwoArrays
{
    static void Main()
    {
        Console.WriteLine("Write a program that reads two arrays from the console and compares them element by element.");
        Console.WriteLine();
        Console.Write("Enter the number of elements for the two arrays: ");     //This is the number fo the elements for the two arryas
        int arrayElements = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the values for the first array:");
        int[] arrayOne = new int[arrayElements];        //This is the first array
        bool equal = true;
        for (int i = 0; i < arrayElements; i++)     //We fill the first array with this cycle
        {
            arrayOne[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        Console.WriteLine("Enter the values for the second array:");
        int[] arrayTwo = new int[arrayElements];    //This is the second array
        for (int i = 0; i < arrayElements; i++)     //We fill the second array with this cycle
        {
            arrayTwo[i] = int.Parse(Console.ReadLine());
        }
        for (int index = 0; index < arrayElements; index++)     //With this cycle we compare the elements of the two arrays
        {
            if (arrayOne[index] != arrayTwo[index] )        // If we have a different element in one of the arrays the result of the bool variable equal will be false
            {
                equal = false;
            }
        }
        if (equal == false)       //If equal is false this means that the arrays are not equal
        {
            Console.WriteLine("The arrays are not equal");
        }
        else       //If equal is true this means that the arrays are equal
        {
            Console.WriteLine("The arrays are equal");
        }
    }
}
