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
			int[] arr={1,2,2,3,4,4,5,6,6,7,8};//sorted array
			//remove duplicates
			//2 pointer slow and fast
			int slow=0;

			int n=arr.Length;
			
			for(int fast=0;fast<n;fast++){
			  if(arr[slow]!=arr[fast])
			  {
			 slow++;
			 arr[slow]=arr[fast];
		
			  }
			  
			}
			Console.Write("[");
			for(int i=0;i<slow+1;i++){
			  Console.Write(arr[i]+" ");
			}
				Console.WriteLine("]");
				
				Console.Write("Length of the new array without duplicates is "+(slow+1));
		}
	}
}