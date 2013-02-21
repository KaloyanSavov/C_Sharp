using System;

class PrintAllCards
{
    static void Main()
    {
        for (int i = 1; i <= 4; i++)
        {
            
            for (int j = 1; j <= 13; j++)
            {
                switch (i)
                {
                    case 1: Console.Write("Clubs "); break;
                    case 2: Console.Write("Diamonds "); break;
                    case 3: Console.Write("Hearts "); break;
                    case 4: Console.Write("Spades "); break;
                    default: break;
                }
                switch (j)
                {
                    case 1: Console.WriteLine("deuce"); break;
                    case 2: Console.WriteLine("three"); break;
                    case 3: Console.WriteLine("four"); break;
                    case 4: Console.WriteLine("five"); break;
                    case 5: Console.WriteLine("six"); break;
                    case 6: Console.WriteLine("seven"); break;
                    case 7: Console.WriteLine("eight"); break;
                    case 8: Console.WriteLine("nine"); break;
                    case 9: Console.WriteLine("ten"); break;
                    case 10: Console.WriteLine("jack"); break;
                    case 11: Console.WriteLine("queen"); break;
                    case 12: Console.WriteLine("king"); break;
                    case 13: Console.WriteLine("ace"); break;
                    default: break;
                }
            }
        }
    }
}