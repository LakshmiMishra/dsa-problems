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
// 20. Maximum Number of Vowels in a Substring of Size K
// Problem Statement:
// Given a string and an integer K, determine
//the maximum number of vowels present in any contiguous substring of size K.
// Input:
// String = "abciiidef"
// K = 3
// Output:
// 3
  string s="abiiidepauf";
  int k=4;
  int res=MaxVowels(s,k);
  Console.Write($"the maximum number of vowels present in any contiguous substring of size {k} is {res}");


		}
		public static int MaxVowels(string s, int k) {
        int n=s.Length;
        int maxVowelSubarray=0;
        int curVowelCounter=0;
        HashSet<char> hash=new HashSet<char>{'a','e','i','o','u'};
        //First window 
        for(int fast=0;fast<k;fast++){
            if(hash.Contains(s[fast]))
                curVowelCounter++;
        }
   
        maxVowelSubarray=curVowelCounter;
        //slide the window
        for(int i=k;i<n;i++){
            if(hash.Contains(s[i]))
            curVowelCounter++;
    
            //to maintain the window size k , we need to remove the left char
            //from the string
            //check whether that char is vowel
            //if yes then decrese the counter
            if(hash.Contains(s[i-k]))
            curVowelCounter--;
      
            maxVowelSubarray=Math.Max(maxVowelSubarray,curVowelCounter);
        }
        return maxVowelSubarray;

    }
	}
}