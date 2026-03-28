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
// 	15. Longest Substring Without Repeating Characters
// Problem Statement:
// Given a string, determine the length of the longest substring that does not contain any repeated characters.
// Input:
// String = "abcabcbb"
// Output:
// 3

string str="abbcab";
int slow=0;
int maxL=0;
HashSet<char> hash=new HashSet<char>();
if(str.Length==0)
{
    Console.WriteLine("Invalid Input");
    return;
}
for(int fast=0;fast<str.Length;fast++){
   
   while(hash.Contains(str[fast])){
         hash.Remove(str[slow]);
         slow++;
   }
   
   if(!hash.Contains(str[fast])){
     hash.Add(str[fast]);

   }
   maxL=Math.Max(maxL,fast-slow+1);
 }
  
  

Console.Write(maxL);

		}
	}
}