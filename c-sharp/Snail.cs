// Link to kata: https://www.codewars.com/kata/521c2db8ddc89b9b7a0000c1

using System;
using System.Collections.Generic;

public class SnailSolution
{
   public enum Directions 
   {
     UP = 0,
     DOWN,
     LEFT,
     RIGHT
   }

   public static int[] Snail(int[][] array)
   {
       if(array[0].Length == 0) return new int[] {};
   
       List<int> result = new List<int>();
       
       int top = 0;
       int bottom = array.GetLength(0) - 1;
       int left = 0;
       int right = array.GetLength(0) - 1;
       
       Directions direction = Directions.RIGHT;
       
       while(top <= bottom && left <= right) 
       {
         switch(direction) 
         { 
           case Directions.RIGHT:
             for(int i = top; i <= right; i++) 
             {
               result.Add(array[top][i]);
             }
             top++;
             direction = Directions.DOWN;
             break;
             
           case Directions.DOWN:
             for(int i = top; i <= bottom; i++) 
             {
               result.Add(array[i][right]);
             }
             right--;
             direction = Directions.LEFT;
             break;
           
           case Directions.LEFT:
             for(int i = right; i >= left; i--) 
             {
               result.Add(array[bottom][i]);
             }
             bottom--;
             direction = Directions.UP;
             break;
             
           case Directions.UP:
             for(int i = bottom; i >= top; i--) 
             {
               result.Add(array[i][left]);
             }
             left++;
             direction = Directions.RIGHT;
             break;
             
           default:
             break;
         }       
       }
                            
       return result.ToArray();
   }
}