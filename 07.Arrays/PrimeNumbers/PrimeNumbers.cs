using System;

class PrimeNumbers
{
    static void Main()
    {
        Console.WriteLine("Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).");
        Console.WriteLine();
        bool[] array = new bool[10000000];      // We have bool array with 10000000 false values
        for (int i = 2; i < Math.Sqrt(array.Length); i++)
        {
            if (array[i] == false) //If the element is false we use it as a divider
            {                      
                for (int j = i*i; j < array.Length; j = j + i)
                {
                    array[j] = true; // When the element is true it is no prime
                }
            }
        }
        for (int i = 2; i < array.Length; i++)
        {
            if (array[i] ==false)
            {
                Console.Write(i); //Printing all the false elements in the array
            }
            Console.WriteLine();
        }
    }
}
