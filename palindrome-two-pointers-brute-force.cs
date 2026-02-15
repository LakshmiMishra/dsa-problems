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
		  
		  // A phrase is a palindrome if, after converting all uppercase letters into lowercase letters
		  // and removing all non-alphanumeric characters, it reads the same forward and backward. 
		  // Alphanumeric characters include letters and numbers.

     //Given a string s, return true if it is a palindrome, or false otherwise.
	   string s= "A man, a plan, a canal: Panama";
	   //Remove all the non alpha numeric characters from the string first
	   
	   string result = Regex.Replace(s, "[^a-zA-Z]", String.Empty);
        int n=result.Length;
        int ei=n-1;
        int si=0;
      //  use two pointers to check
      while(si<=ei){
            if(Char.ToUpper(result[si])==Char.ToUpper(result[ei]))
            {   si++;
                ei--;
            }
            else
            return false;

        }
        return true; 
		}
	}
	}
