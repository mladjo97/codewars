// linkt to kata: https://www.codewars.com/kata/52774a314c2333f0a7000688

using System;
using System.Collections.Generic;


public class Parentheses
{
    public static bool ValidParentheses(string input)
    {
        if(input.Length < 0 || input.Length > 100) return false;
        
        Stack<char> stack = new Stack<char>();
          
        foreach(char c in input) 
        {
          if(c == '(') { stack.Push(c); continue; }
          
          if(c == ')') {
            try
            {
              char stackPop = stack.Pop();
              if(stackPop != '(') return false;
            } 
            catch(InvalidOperationException)
            {
              return false;
            }
          }
        }
        
        if(stack.Count > 0) return false;
        
        return true;
    }
}