using System;
using System.Collections.Generic;

class Program
{
    static int Maior(List<int> l)
    {
        int m = l[0];

        foreach (int n in l)
        {
            if (n > m)
                m = n;
        }
        return m;
    }

    static void Main()
    {
        var nums = new List<int> { 3, 7, 1, 9, 4 };
        Console.WriteLine(Maior(nums));
    }
}
