using System;

class CompareCharArrays
{
    static void Main()
    {
        Console.WriteLine("Write a program that compares two char arrays lexicographically (letter by letter).");
        Console.WriteLine();
        Console.WriteLine("Enter the number of elements fot the first array");
        int firstArrayElements = int.Parse(Console.ReadLine());
        char[] firstArray = new char[firstArrayElements];
        for (int i = 0; i < firstArrayElements; i++)        //Fill the first array with values
        {
            firstArray[i] = Convert.ToChar(Console.ReadLine());
        }
        Console.WriteLine();
        Console.WriteLine("Enter the number of elements fot the second array");
        int secondArrayElements = int.Parse(Console.ReadLine());
        char[] secondArray = new char[secondArrayElements];
        for (int i = 0; i < secondArrayElements; i++)       //Fill the second array with values
        {
            secondArray[i] = Convert.ToChar(Console.ReadLine());
        }
        if (firstArrayElements == secondArrayElements)      //Compare if the two arrays have the same number of elements
        {
            for (int i = 0; i < firstArrayElements; i++)
            {
                if (firstArray[i] == secondArray[i])        //If the elements are equal the for cycle continues
                {
                    continue;
                }
                else if (firstArray[i] > secondArray[i])    //If the element from the first array is bigger we print the result and the cycle stops
                {
                    Console.WriteLine("Lexicographically second array is before first array");
                    break;
                }
                else
                {
                    Console.WriteLine("Lexicographically first array is before second array"); //If the element from the second array is bigger we print the result and the cycle stops
                    break;
                }
            }
        }
        else if (firstArrayElements > secondArrayElements)      //The array with the less elements is Lexicographically first
        {
            Console.WriteLine("Lexicographically second array is before first array");
        }
        else if (firstArrayElements < secondArrayElements)      //The array with the less elements is Lexicographically first
        {
            Console.WriteLine("Lexicographically first array is before first array");
        }
        else    // This is the case when the two arrays have equal elements
        {
            Console.WriteLine("All elements of the two arrays are equal");
        }
    }
}
