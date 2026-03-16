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
      // 		Q4. Find the longest substring without repeating characters
      // Problem Statement:
      // Given a string, find the length of the longest substring that contains no repeating characters.
      // Input:
      // s = "abcabcbb"
      // Output:
      // 3
      string s="abcabcbb";
      Console.Write(LengthOfLongestSubstring(s));

      
		}
		public static int LengthOfLongestSubstring(string s) {
        
        int slow=0;
        int fast=0;
        int maxLength=0;
        
        HashSet<char> hashset=new HashSet<char>();
        while(fast<s.Length)
        {
          if(!hashset.Contains(s[fast]))
          {
            
            hashset.Add(s[fast]);
            int curLength =fast-slow+1;
            fast++;
            maxLength=Math.Max(maxLength,curLength);
          }
          else
          {
            hashset.Remove(s[slow]);
            slow++;
          }
          
        }
        return maxLength;
       }
	}
}