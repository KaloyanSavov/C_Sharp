using System;

class GreatestOfFiveVariables
{
    static void Main()
    {
        Console.WriteLine("Enter the first variable: ");
        int firstVariable = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second variable: ");
        int secondVariable = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third variable: ");
        int thirdVariable = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the fourth variable: ");
        int fourthVariable = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the fifth variable: ");
        int fifthVariable = int.Parse(Console.ReadLine());
        if (firstVariable > secondVariable & firstVariable > thirdVariable & firstVariable > fourthVariable & firstVariable > fifthVariable)
        {
            Console.WriteLine("The biggest number is: {0}", firstVariable);
        }
        else if (secondVariable > firstVariable & secondVariable > thirdVariable & secondVariable > fourthVariable & secondVariable > fifthVariable)
        {
            Console.WriteLine("The biggest number is: {0}", secondVariable);
        }
        else if (thirdVariable > firstVariable & thirdVariable > secondVariable & thirdVariable > fourthVariable & thirdVariable > fifthVariable)
        {
            Console.WriteLine("The biggest number is: {0}", thirdVariable);
        }
        else if (fourthVariable > firstVariable & fourthVariable > secondVariable & fourthVariable > thirdVariable & fourthVariable > fifthVariable)
        {
            Console.WriteLine("The biggest number is: {0}", fourthVariable);
        }
        else if (fifthVariable > firstVariable & fifthVariable > secondVariable & fifthVariable > thirdVariable & fifthVariable > fourthVariable)
        {
            Console.WriteLine("The biggest number is: {0}", fifthVariable);
        }
    }
}