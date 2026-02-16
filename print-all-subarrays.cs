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
		  int[] arr={1,2,4,6,8,9,4};
		  int n= arr.Length-1;
		  //number of sub arrays = n*(n+1)/2=7*8/2=28
		  for(int i=0;i<n;i++){
		    for(int j=i;j<n;j++){
		      Console.Write("Subarry:[");
		      for(int k=i;k<=j;k++){
		        	Console.Write(arr[k]+",");
		      }
		      		Console.WriteLine("]");
		      	
		    }
		  }
	
		}
	}
}