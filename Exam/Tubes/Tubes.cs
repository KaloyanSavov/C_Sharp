using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class Tubes
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int[] tubesLenght = new int[n];
        for (int i = 0; i < tubesLenght.Length; i++)
        {
            tubesLenght[i] = int.Parse(Console.ReadLine());
        }
        int min = 0;
        int max = tubesLenght.Max();
        int middle = 0;
        int tubes = 0;
        int maxLenght = 0;
        while (min <= max)
        {
            tubes = 0;
            middle = (min + max) / 2;
            for (int i = 0; i < tubesLenght.Length; i++)
            {
                tubes = tubes + tubesLenght[i] / middle;
            }
            if (tubes >= m)
            {
                min = middle + 1;
                maxLenght = middle;
            }
            else
            {
                max = middle - 1;
            }
            
        }
        Console.WriteLine(maxLenght);
    }
}

////// BGCODER 100/100