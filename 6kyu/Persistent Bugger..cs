//https://www.codewars.com/kata/55bf01e5a717a0d57e0000ec/csharp

using System;
using System.Linq;

public class Persist
{
    public static int Persistence(long n)
    {
        var repeatCount = 0;

        while (n >= 10)
        {
            n = GetNextNum(n);
            repeatCount++;
        }

        return repeatCount;
    }

    public static long GetNextNum(long num)
    {
        long result = 1;

        foreach (var item in num.ToString().Select(d => long.Parse(d.ToString())))
        {
            result *= item;
        }

        return result;
    }
}