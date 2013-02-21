using System;

class IndexOfBiggerThanTwoNeighboursMethod
{
    static int IndexOfBiggerThanTwoNeighbours(int[] array) //This method checks the two neighbours
    {
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1] && array[i] > array[i -1])
            {
                return i; //If we find a couple of neighbours that are smaller than the wanted element we returs the index of the element
            }
        }
        int noElement = -1;
        return noElement; //If we didn't find a couple of neighbours we returns -1
    }
    static void Main()
    {
        Console.WriteLine("Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.");
        Console.WriteLine();
        Console.WriteLine("Enter a value for the array elements:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the values for the array elements:");
        int[] array = new int[number + 1];
        for (int i = 0; i < array.Length - 1; i++) //Fill the array
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        if (IndexOfBiggerThanTwoNeighbours(array) == -1) //Calling method
        {
            Console.WriteLine("No element found.");
        }
        else
        {
            Console.WriteLine("The the index of the element is {0}", IndexOfBiggerThanTwoNeighbours(array)); //Calling method
        }
    }
}
