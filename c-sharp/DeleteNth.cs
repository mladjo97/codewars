// Link to kata: https://www.codewars.com/kata/554ca54ffa7d91b236000023

using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
    public static int[] DeleteNth(int[] arr, int x)
    {
        Dictionary<int, int> occurences = new Dictionary<int, int>();
        foreach (int digit in arr)
        {
            if (!occurences.ContainsKey(digit)) occurences.Add(digit, 0);
        }

        List<int> digitsList = new List<int>();
        foreach (int digit in arr)
        {
            occurences[digit] += 1;
            if (occurences[digit] > x) continue;

            digitsList.Add(digit);
        }

        return digitsList.ToArray();
    }
}