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
		int[] arr={4, 2, 1, 7, 8, 1, 2, 8, 1, 0};
		int n=arr.Length;
		int minSum=int.MaxValue;
		int size=3;
		//Minimum Sum Subarray of Size K
		//Size K , Subarray sliding window fixed Size
		
		//first window
		int wSum=0;
		for(int i=0;i<size;i++){
		  wSum+=arr[i];
		}
		minSum=wSum;//assign first window sum to minSum
		//slide the first window and find all the sums for other windows
		for(int i=size;i<n;i++){
		  
		  wSum=wSum+arr[i]-arr[i-size];
		  minSum=Math.Min(minSum,wSum);
		}
		Console.Write("Minimum possible sum "+minSum);
		}
	}
}