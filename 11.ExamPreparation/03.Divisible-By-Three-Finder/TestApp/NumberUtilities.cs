using System;
using System.Collections.Generic;

namespace TestApp;

public class NumberUtilities
{
    public static string GetDivisibleByThree(List<int> numbers)
    {
        if (numbers == null || numbers.Count == 0)
        {
            return string.Empty;
        }

        List<int> divisible = new List<int>();

        foreach (var item in numbers)
        {
            if(item % 3 == 0 && !divisible.Contains(item))
            {
                divisible.Add(item);
            }
        }

        if (divisible.Count == 0)
        {
            return string.Empty;
        }

        return string.Join(", ", divisible);
    }
}
