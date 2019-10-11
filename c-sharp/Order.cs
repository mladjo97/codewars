// Link to kata: https://www.codewars.com/kata/55c45be3b2079eccff00010f

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public static class Kata
{
    public static string Order(string words)
    {
        if (String.IsNullOrEmpty(words))
            return string.Empty;

        string[] tokens = words.Split(' ');

        Dictionary<int, string> sentenceOrders = new Dictionary<int, string>();

        foreach (string token in tokens)
        {
            int sentenceOrder = Int32.Parse(Regex.Match(token, @"\d+").Value);
            sentenceOrders.Add(sentenceOrder, token);
        }

        List<string> sentenceList = sentenceOrders.OrderBy(s => s.Key).Select(v => v.Value).ToList();
        return String.Join(' ', sentenceList);
    }
}