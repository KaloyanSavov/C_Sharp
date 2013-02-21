using System;

class MaxPlatform3x3
{
    static void Main()
    {
        Console.WriteLine("Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.");
        Console.WriteLine();
        int [,] matrixArray = {
            { 2 , 3 , 0 , 6 , 9 , 5 , 4 , 2 },
            { 9 , 5 , 3 , 8 , 4 , 1 , 9 , 3 },
            { 3 , 8 , 9 , 4 , 6 , 0 , 4 , 1 },
            { 4 , 5 , 9 , 6 , 7 , 1 , 4 , 3 },
            { 1 , 3 , 5 , 7 , 9 , 5 , 4 , 4 }
        };
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        int sum = 0;
        for (int row = 0; row < matrixArray.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrixArray.GetLength(1) - 2; col++)
            {
                sum = matrixArray[row , col] + matrixArray[row , col + 1] + matrixArray[row , col + 2] +        // Checks the sum of the current 3x3 platform
                    matrixArray[row + 1 , col] + matrixArray[row + 1, col + 1] + matrixArray[row + 1 , col + 2] + 
                    matrixArray[row + 2 , col] + matrixArray[row + 2 , col + 1] + matrixArray[row + 2, col + 2];
                if (sum > bestSum) //If we find the best sum we collect the index of the first element of the 3x3 platform
	            {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
	            }
            }
        }
        Console.WriteLine(bestSum);
    }
}
