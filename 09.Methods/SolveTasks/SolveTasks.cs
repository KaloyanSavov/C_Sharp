using System;
using System.Collections.Generic;

class SolveTasks
{
    static void ReverseDigits(decimal number) //We use the method that we used in 07.ReverseDigitsMethod
    {
        string numberConvert = number.ToString();
        char[] array = numberConvert.ToCharArray();
        for (int i = array.Length - 1; i >= 0; i--)
        {
                Console.Write(array[i]);
        }
        Console.WriteLine();
    }

    static void AverageOfASequence(double[] sequence) //This method sums all the elements in the array and divides the sum by the lenght of the array
    {
        double result = 0;
        for (int i = 0; i < sequence.Length ; i++)
			{
                result += sequence[i];
			}
        result = result / sequence.Length;
        Console.WriteLine("The average of the sequence is {0}: " , result);
    }

    static void LinearEquation(double a, double b) // We can you this method or the method that is used in 11.Polynominals
    {
        double result = 0;
        result = -(b) / a;
        Console.WriteLine("The resut of the linear equation is {0}." , result);
    }

    static void Main()
    {
        Console.WriteLine("Write a program that can solve these tasks:");
        Console.WriteLine("Reverses the digits of a number");
        Console.WriteLine("Calculates the average of a sequence of integers");
        Console.WriteLine("Solves a linear equation a * x + b = 0");
        Console.WriteLine("Create appropriate methods.");
        Console.WriteLine("Provide a simple text-based menu for the user to choose which task to solve.");
        Console.WriteLine("Validate the input data:");
        Console.WriteLine("The decimal number should be non-negative");
        Console.WriteLine("The sequence should not be empty");
        Console.WriteLine("a should not be equal to 0");
        Console.WriteLine();
        Console.WriteLine("Choose the task you want to solve:");
        Console.WriteLine("1. Reverses the digits of a number");
        Console.WriteLine("2. Calculates the average of a sequence of integers");
        Console.WriteLine("3. Solves a linear equation a * x + b = 0");
        int choise = int.Parse(Console.ReadLine());
        if (choise == 1)
	    {
		    Console.WriteLine("Enter a positive number that you want to reverse:");
            decimal number = int.Parse(Console.ReadLine());
            if (number <= 0)
	        {
                Console.WriteLine("Wrong number.");
	        }
            else
            {
                ReverseDigits(number); //Calling Method
            }
	    }
        else if (choise == 2)
        {
            Console.WriteLine("Enter the lenght of the sequence:");
            int lenght = int.Parse(Console.ReadLine());
            if (lenght <= 0)
            {
                Console.WriteLine("The sequence should not be empty");
            }
            else
            {
                double[] sequence = new double[lenght];
                for (int i = 0; i < sequence.Length; i++)
                {
                    sequence[i] = double.Parse(Console.ReadLine());
                }
                AverageOfASequence(sequence); //Calling Method
            }
        }
        else if (choise == 3)
        {
            Console.WriteLine("Enter a value for 'a':");
            double a  = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value for 'b':");
            double b = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("'a' should not be equal to zero!");
            }
            else
            {
                LinearEquation(a, b); //Calling Method
            }
        }
        else
        {
            Console.WriteLine("Wrong choise!");
        }
    }
}
