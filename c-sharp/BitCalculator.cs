// Link to kata: https://www.codewars.com/kata/52ece9de44751a64dc0001d9

using System;

public class Kata
{
    public static int Calculate(string num1, string num2)
    {
        int result = 0;

        for (int i = 0; i < num1.Length; i++)
        {
            if (num1[i] == '1')
            {
                result += (int)Math.Pow(2, num1.Length - i - 1);
            }
        }

        for (int i = 0; i < num2.Length; i++)
        {
            if (num2[i] == '1')
            {
                result += (int)Math.Pow(2, num2.Length - i - 1);
            }
        }

        return result;
    }
}