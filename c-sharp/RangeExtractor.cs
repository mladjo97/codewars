// Link to kata: https://www.codewars.com/kata/51ba717bb08c1cd60f00002f

using System;
using System.Linq;
using System.Collections.Generic;

public class RangeExtraction
{
    public static string Extract(int[] args)
    {
        return String.Join(",", RangesToString(GetRanges(args)));
    }

    private static IEnumerable<IEnumerable<int>> GetRanges(int[] numbers)
    {
        List<int> range = new List<int>();

        foreach (int number in numbers)
        {
            if (range.Count == 0)
            {
                range.Add(number);
            }
            else
            {
                if (range.Max() + 1 == number)
                {
                    range.Add(number);
                }
                else
                {
                    yield return range;
                    range = new List<int>() { number };
                }
            }
        }
        yield return range;
    }

    private static IEnumerable<string> RangesToString(IEnumerable<IEnumerable<int>> ranges)
    {
        foreach (IEnumerable<int> range in ranges)
        {
            if (range.Count() == 1)
            {
                yield return range.Single().ToString();
            }
            else if (range.Count() == 2)
            {
                yield return range.Min() + "," + range.Max();
            }
            else
            {
                yield return range.Min() + "-" + range.Max();
            }
        }
    }

}