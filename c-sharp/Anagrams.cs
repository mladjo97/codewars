// Link to kata: https://www.codewars.com/kata/523a86aa4230ebb5420001e1

using System;
using System.Linq;
using System.Collections.Generic;

public static class Kata
{
    public static List<string> Anagrams(string word, List<string> words)
    {
        List<string> anagrams = new List<string>();

        char[] wordChars = word.ToLower().ToCharArray();
        Array.Sort(wordChars);
        string newWord = new string(wordChars);

        foreach (string inputWord in words)
        {
            char[] inputWordChars = inputWord.ToLower().ToCharArray();
            Array.Sort(inputWordChars);
            string newInputWord = new string(inputWordChars);

            if (newWord.Equals(newInputWord))
                anagrams.Add(inputWord);
        }

        return anagrams;
    }
}