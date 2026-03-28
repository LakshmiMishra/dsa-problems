using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
// 22. Fruit Into Baskets
// Problem Statement:
// You are given an array representing types of fruits in a row of trees. You can collect fruits from at most two different types of fruits. Find the maximum number of fruits you can collect in a contiguous sequence.
// Input:
// Array = [1, 2, 1]
// Output:
// 3
// Input: fruits = [1,2,3,2,2]
// Output: 4
// Explanation: We can pick from trees [2,3,2,2].
// If we had started at the first tree, we would only pick from trees [1,2].

int[] fruits = {1,2,2,2,1,7};
  int n=fruits.Length;
        int slow=0;
        int maxL=0;
        int basket=2;//only 2 distinct type of fruits for 2 basket
        Dictionary<int,int> dict=new Dictionary<int,int>();
        for(int fast=0;fast<n;fast++){
            if(!dict.ContainsKey(fruits[fast])){
                dict.Add(fruits[fast],0);
            }
            dict[fruits[fast]]++;//increase the freq
            //in dict there should be atmost 2 types of fruits
          while(dict.Count>basket)
            {
            dict[fruits[slow]]--;//decrease the fruit type 1 
           // check if the basket is empty
           if(dict[fruits[slow]]==0)
           dict.Remove(fruits[slow]);
           slow++  ;              
            }
            maxL=Math.Max(maxL,fast-slow+1);
        }
     
Console.WriteLine("Maximum fruits collected: " + maxL);

		}
	}
}