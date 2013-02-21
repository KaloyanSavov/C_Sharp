using System;

class MissCat2011
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int scoreOne = 0;
        int scoreTwo = 0;
        int scoreThree = 0;
        int scoreFour = 0;
        int scoreFive = 0;
        int scoreSix = 0;
        int scoreSeven = 0;
        int scoreEight = 0;
        int scoreNine = 0;
        int scoreTen = 0;
        int scoreMax = 0;
        for (int i = 1; i <= n; i++)
        {
            int score = int.Parse(Console.ReadLine());
            switch (score)
            {
                case 1: scoreOne++; break;
                case 2: scoreTwo++; break;
                case 3: scoreThree++; break;
                case 4: scoreFour++; break;
                case 5: scoreFive++; break;
                case 6: scoreSix++; break;
                case 7: scoreSeven++; break;
                case 8: scoreEight++; break;
                case 9: scoreNine++; break;
                case 10: scoreTen++; break;
                default:
                    break;
            }
        }
        if (scoreOne > scoreTwo)
        {
            scoreMax = scoreOne;
        }
        else
        {
            scoreMax = scoreTwo;
        }
        if (scoreThree > scoreMax)
        {
            scoreMax = scoreThree;
        }
        if (scoreFour > scoreMax)
        {
            scoreMax = scoreFour;
        }
        if (scoreFive > scoreMax)
        {
            scoreMax = scoreFive;
        }
        if (scoreSix > scoreMax)
        {
            scoreMax = scoreSix;
        }
        if (scoreSeven > scoreMax)
        {
            scoreMax = scoreSeven;
        }
        if (scoreEight > scoreMax)
        {
            scoreMax = scoreEight;
        }
        if (scoreNine > scoreMax)
        {
            scoreMax = scoreNine;
        }
        if (scoreTen > scoreMax)
        {
            scoreMax = scoreTen;
        }
        if (scoreMax == scoreOne)
        {
            Console.WriteLine("1");
        }
        if (scoreMax == scoreTwo)
        {
            Console.WriteLine("2");
        }
        if (scoreMax == scoreThree)
        {
            Console.WriteLine("3");
        }
        if (scoreMax == scoreFour)
        {
            Console.WriteLine("4");
        }
        if (scoreMax == scoreFive)
        {
            Console.WriteLine("5");
        }
        if (scoreMax == scoreSix)
        {
            Console.WriteLine("6");
        }
        if (scoreMax == scoreSeven)
        {
            Console.WriteLine("7");
        }
        if (scoreMax == scoreEight)
        {
            Console.WriteLine("8");
        }
        if (scoreMax == scoreNine)
        {
            Console.WriteLine("9");
        }
        if (scoreMax == scoreTen)
        {
            Console.WriteLine("10");
        }
    }
}
