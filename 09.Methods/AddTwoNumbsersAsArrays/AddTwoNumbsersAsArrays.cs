using System;

class AddTwoNumbsersAsArrays
{
    static void AddNumbers(int[] firstArray, int[] secondArray)
    {
        Array.Reverse(firstArray);      //To sum the digits first we must reverse the arrays
        Array.Reverse(secondArray);
        if (firstArray.Length > secondArray.Length) //If the lenght of the first array is bigger than the lenght of the second array
        {                                           // the sum will be in the first array
            for (int i = 1; i < secondArray.Length; i++)
            {
                if (firstArray[i] + secondArray[i] < 10) //If the sum of the two digits is less than ten there is no carry
                {
                    firstArray[i] = firstArray[i] + secondArray[i];
                }
                else
                {
                    firstArray[i] = firstArray[i] + secondArray[i] - 10; //Then the sum is more than then we have carry to the next digits
                    firstArray[i + 1]++;
                    int temp = 0;
                    while (firstArray[i + 1 + temp] == 10) //This is when the carry is for more than one element
                    {
                        firstArray[i + 1 + temp] = 0;
                        temp++;
                        firstArray[i + 1 + temp]++;
                    }
                }
            }
            Array.Reverse(firstArray); //We reverse the array again 
            if (firstArray[0] == 0)
            {
                for (int i = 1; i < firstArray.Length; i++)
                {
                    Console.Write(firstArray[i]);
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    Console.Write(firstArray[i]);
                }
                Console.WriteLine();
            }
           
        }
        else //This is when the lenght of the second array is bigger then the lenght of the first array
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] + secondArray[i] < 10)
                {
                    secondArray[i] = secondArray[i] + firstArray[i];
                }
                else
                {
                    secondArray[i] = secondArray[i] + firstArray[i] - 10;
                    secondArray[i + 1]++;
                    int temp = 0;
                    while (secondArray[i + 1 + temp] == 10)
                    {
                        secondArray[i + 1 + temp] = 0;
                        temp++;
                        secondArray[i + 1 + temp]++;
                    }
                }
            }
            Array.Reverse(secondArray);
            if (secondArray[0] == 0)
            {
                for (int i = 1; i < secondArray.Length; i++)
                {
                    Console.Write(secondArray[i]);
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < secondArray.Length; i++)
                {
                    Console.Write(secondArray[i]);
                }
                Console.WriteLine();
            }
           
        }
    }
    static void Main()
    {
        Console.WriteLine("Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.");
        Console.WriteLine();
        Console.WriteLine("Enter the number of the elements for the first array:");
        int numberFirstArray = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the digits:");
        int[] firstArray = new int [numberFirstArray + 1];
        for (int i = 1; i < firstArray.Length; i++) //Fill the first Array
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter the number of the elements for the second array:");
        int numberSecondArray = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the digits:");
        int[] secondArray = new int [numberSecondArray + 1]; //Fill the second Array
        for (int i = 1; i < secondArray.Length; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }
        AddNumbers(firstArray ,secondArray); //Calling method

    }
}
