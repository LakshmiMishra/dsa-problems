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
			//13.	Devise a method to find the subarray with the minimum sum.
// 	Input : arr[] = {5, 6, 3, 5, 7, 8, 9, 1, 2}
// Output : 5
// The subarray is {3, 5, 7, 8, 9}


    int[] arr={5, -6, -3, 5, 7, 8, 9, 1, 2};
    int n= arr.Length;
  //find all sub arrays and there sums 
   int curSum=0;
   string subArr="";
   int minSum=int.MaxValue;
    for(int i=0; i<n;i++)
     {
       subArr+=arr[i]+" ";
         curSum+=arr[i];
         curSum=Math.Min(curSum,arr[i]);
          minSum=Math.Min(curSum,minSum);
       
         Console.Write("subarray is  "+subArr);
               
         Console.WriteLine("current sum is  "+curSum);
       
  
     }
   Console.WriteLine("minimum sum  of subarray "+minSum);
      
		}
	}
}