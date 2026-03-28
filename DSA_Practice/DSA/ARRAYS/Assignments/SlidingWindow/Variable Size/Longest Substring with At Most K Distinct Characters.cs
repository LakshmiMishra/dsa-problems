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
// 			16. Longest Substring with At Most K Distinct Characters
// Problem Statement:
// You are given a string and an integer K. 
//Find the length of the longest substring that contains at most K distinct characters.
// Input:
// String = "eceba"
// K = 2
// Output:
// 3

string s="ddrddefgh";
int slow=0;
int maxL=0;
int k=2;
            if (s.Length == 0)
            {
                Console.Write("Invalid Input");
break;
            }


Dictionary<char,int> dict=new Dictionary<char,int>();
for(int fast=0;fast<s.Length;fast++){
  
  if(!dict.ContainsKey(s[fast])){
  dict.Add(s[fast],0);
  }
  dict[s[fast]]++;
 
  while(dict.Count>k)//if dict length increase k then shrink the window
  {
    dict[s[slow]]--;
    if(dict[s[slow]]==0)
    {
    dict.Remove(s[slow]);
   
    } 
    slow++;
  }
   maxL=Math.Max(maxL,fast-slow+1);
}
Console.Write(maxL);


		}
	}
}