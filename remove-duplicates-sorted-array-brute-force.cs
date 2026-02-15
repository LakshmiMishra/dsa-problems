//Description: Given a sorted array, remove duplicates in-place and return the
//length of the new array with unique elements.
//Input: nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4]
//Output: 5 (array becomes [0, 1, 2, 3, 4])
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
		//	int[] arr={0,0,0,1,1,2,2,2,3,3,4,4,4,4,4,5};
			int[] arr={-1,-1,0,0,1,1,2,2,2,3,3,4,4,4,4,4,5};
			List<int> uniqueElements=new List<int>();
			uniqueElements.Add(arr[0]);//Sinec it is a sorted array, list will have first elemeny
			//removing duplicates by brute force
			for(int i=0;i<arr.Length-1;i++){
			  
  			 if(arr[i]!=arr[i+1])
  			 {
  			   uniqueElements.Add(arr[i+1]);
  			 }
	     	}
	     	Console.Write("[");
			  foreach(int a in uniqueElements){
			    Console.Write(a+",");
			  }
			      	Console.Write("]");
			}
		}
	}
