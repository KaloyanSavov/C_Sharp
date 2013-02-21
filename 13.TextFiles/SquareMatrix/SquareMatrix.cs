using System;
using System.IO;

class SquareMatrix
{
    static void Main()
    {
        Console.WriteLine("Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. The first line in the input file contains the size of matrix N. Each of the next N lines contain N numbers separated by space. The output should be a single number in a separate text file. Example:");
        Console.WriteLine("4");
        Console.WriteLine("2 3 3 4");
        Console.WriteLine("0 2 3 4	-> 17");
        Console.WriteLine("3 7 1 2");
        Console.WriteLine("4 3 3 2");
        Console.WriteLine();
        StreamReader reader = new StreamReader("matrix.txt");
        using (reader)
        {
            int size = int.Parse(reader.ReadLine());
            int[,] matrix = new int[size, size];
            string line = reader.ReadLine() ;
            int matrixLine = 0;
            while (line != null)
            {
                string[] numbers = line.Split(' ');
                for (int col = 0; col < numbers.Length; col++)
                {
                    matrix[matrixLine, col] = int.Parse(numbers[col]);  
                }
                matrixLine++;
                line = reader.ReadLine();
            }
            int bestSum = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (sum > bestSum)
                        bestSum = sum;
                }
            StreamWriter writer = new StreamWriter("output.txt");
            using(writer)
	        {
                writer.WriteLine(bestSum);
	        }
        }
    }
}
