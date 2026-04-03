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
		 int[] arr={2,4,6,8,10};
		 int[] L={1,3};
		 int[] R={0,4};
		 int n=arr.Length;
	   int[] prefix=new int[n];
	   // Given an array nums and multiple queries [L, R], return the sum of elements from index L to R (inclusive) for each query.
// Use prefix sum to optimize.
// nums = [2, 4, 6, 8, 10]
// queries = [(1, 3), (0, 4)]
// Output: [18, 30]
      prefix[0]=arr[0];
	   for(int i=1;i<n;i++){
	     prefix[i]=prefix[i-1]+arr[i];
	   
	   }
	   int a= findSum(L[0],L[1],prefix);
	     int b= findSum(R[0],R[1],prefix);
	     Console.Write("["+a+","+b+"]");

		}
		//review the code and find the errors
		static int findSum(int s,int e, int[] p){
		  if(s==0){
			return p[e];
		  }
		  return p[e]-p[s-1];
	}
	}
}