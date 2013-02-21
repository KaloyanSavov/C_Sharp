using System;

class MatrixFill
{
    static void Main()
    {
        Console.WriteLine("Enter a number for n:");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int value = 1;
        Console.WriteLine("Matrix A");
        for (int row = 1; row <= matrix.GetLength(0); row++)
        {
            for (int col = row; col <= n*n; col += n)
            {
                Console.Write(col + " ");
                
            }
            Console.WriteLine();
            
        }
        Console.WriteLine();
        Console.WriteLine("Matrix B");
        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0 )
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = value;
                    value++;
                }
            }
            else
            {
                for (int row = n - 1; row >=  0; row--)
                {
                    matrix[row, col] = value;
                    value++;
                }
            }
        }
        for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    Console.Write(matrix[col , row]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
    }
}
