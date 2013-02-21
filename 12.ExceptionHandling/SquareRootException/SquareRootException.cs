using System;

    class SquareRootException
    {
        static void Main()
        {
            Console.WriteLine("Write a program that reads an integer number and calculates and prints its square root. If the number is invalid or negative, print 'Invalid number'. In all cases finally print 'Good bye'. Use try-catch-finally.");
            Console.WriteLine();
            try
            {
                Console.WriteLine("Enter a number:");
                int number = int.Parse(Console.ReadLine());
                if (number <= 0)
                {
                    throw new System.ArithmeticException();
                }
                double squareRoot = Math.Sqrt(number);
                Console.WriteLine("Square root of {0} is {1}.", number, squareRoot);
            }
            catch (System.ArithmeticException)
            {
                Console.WriteLine("Invalid Number!");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Invalid Number!");
            }
            finally
            {
                Console.WriteLine("Good Bye");
            }
        }
    }
