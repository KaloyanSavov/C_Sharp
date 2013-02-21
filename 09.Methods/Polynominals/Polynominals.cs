using System;

    class Polynominals
    {
        static void AddPolynominals(int[] firstArray, int[] secondArray) // The method is identical to this in 08.AddTwoNumbsersAsArrays
        {                                                                // The difference is that we don't have carry in this case
            Array.Reverse(firstArray);
            Array.Reverse(secondArray);
            if (firstArray.Length >= secondArray.Length)
            {
                for (int i = 0; i < secondArray.Length; i++)
                {
                        firstArray[i] = firstArray[i] + secondArray[i];
                }
                Array.Reverse(firstArray);
                for (int i = 1; i < firstArray.Length - 1; i++)
                {
                    Console.Write("{0}x^{1}", firstArray[i], (firstArray.Length - 1) - i);
                    Console.Write(" + ");
                }
                Console.Write(firstArray[firstArray.Length - 1]);
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                        secondArray[i] = secondArray[i] + firstArray[i];
                }
                Array.Reverse(secondArray);
                Console.WriteLine("The sum of the polynominals is:");
                for (int i = 1; i < secondArray.Length - 1; i++)
                {
                    Console.Write("{0}x^{1}", secondArray[i], (secondArray.Length - 1) - i);
                    Console.Write(" + ");
                }
                Console.Write(secondArray[secondArray.Length - 1]);
                Console.WriteLine();
            }
        }
        static void Main()
        {
            Console.WriteLine("Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:");
            Console.WriteLine("x2 + 5 = 1x2 + 0x + 5 -> 5 0 1");
            Console.WriteLine();
            Console.WriteLine("Enter the degree of the first polynominal:");
            int firstDegree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the coeficients of the polynominal:");
            int[] firstArray = new int[firstDegree + 1];
            for (int i = 1; i < firstArray.Length; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("This is the first polynominal:");
            for (int i = 1; i < firstArray.Length - 1; i++)
            {
                Console.Write("{0}x^{1}", firstArray[i], (firstArray.Length - 1) - i);
                Console.Write(" + ");
            }
            Console.Write(firstArray[firstArray.Length - 1]);
            Console.WriteLine();
            Console.WriteLine("Enter the degree of the second polynominal:");
            int secondDegree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the coeficients of the polynominal:");
            int[] secondArray = new int[secondDegree + 1];
            for (int i = 1; i < secondArray.Length; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("This is the second polynominal:");
            for (int i = 1; i < secondArray.Length - 1; i++)
            {
                Console.Write("{0}x^{1}", secondArray[i], (secondArray.Length - 1) - i);
                Console.Write(" + ");
            }
            Console.Write(secondArray[secondArray.Length - 1]);
            Console.WriteLine();
            AddPolynominals(firstArray, secondArray);
        }
    }
