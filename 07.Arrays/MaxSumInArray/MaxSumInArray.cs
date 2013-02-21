using System;

class MaxSumInArray
{
    static void Main()
    {
        Console.WriteLine("Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.");
        Console.WriteLine();
        Console.WriteLine("Enter the number for the elements N of the the array:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Enter the number for the К elements:");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)     //This cycle fills the values of the elements for the array
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int sum = 0;
        int maxSum = 0;
        int sequenceStart = 0;
        for (int i = 0; i < n - k + 1; i++)     // Checks the different siquences
		{
            for (int j = i; j < k + i; j++)
			{
			  sum = sum + array[j];
			}			 
            if (sum > maxSum)
	        {
	            maxSum = sum;
                sequenceStart = i;
                sum = 0;
	        }
            else
	        {
                sum = 0;   
	        }
		}
        Console.WriteLine("The max sum of the k elements is: {0}" , maxSum); //Prints the max sum
    }
}
