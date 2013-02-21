using System;

class BonusScores
{
    static void Main()
    {
        Console.WriteLine("Enter one digit:");
        string digit = Console.ReadLine();
        int newDigit;
        bool check = int.TryParse(digit, out newDigit);
        if (!check)
        {
            Console.WriteLine("Not a digit");
        }
        else
        {
            switch (newDigit)
            {
                case 1: Console.WriteLine("Result is : {0}" , int.Parse(digit) * 10); break;
                case 2: Console.WriteLine("Result is : {0}" , int.Parse(digit) * 10); break;
                case 3: Console.WriteLine("Result is : {0}" , int.Parse(digit) * 10); break;
                case 4: Console.WriteLine("Result is : {0}" , int.Parse(digit) * 100); break;
                case 5: Console.WriteLine("Result is : {0}" , int.Parse(digit) * 100); break;
                case 6: Console.WriteLine("Result is : {0}" , int.Parse(digit) * 100); break;
                case 7: Console.WriteLine("Result is : {0}" , int.Parse(digit) * 1000); break;
                case 8: Console.WriteLine("Result is : {0}" , int.Parse(digit) * 1000); break;
                case 9: Console.WriteLine("Result is : {0}" , int.Parse(digit) * 1000); break;
                case 0: Console.WriteLine("Error"); break;
                default:
                    break;
            }
        }
    }
}
