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
	  int[] arr={6,-1,2,-8,-8,9,0};
			//int[] arr={0};
		//6.	Construct a procedure to find the maximum product subarray.
		//find all subarrays and their products and find the max
	//	product of all the elements in the subarray should be >0
		//then only we can say that maximum product
		int n= arr.Length;
		int maxProd=1;
		for(int i=0;i<n;i++)
		{
		  int prod=1;
		  string subArr="";
		  for( int j=i;j<n;j++)
		  {
		    prod=prod*arr[j];
		  
		  subArr+=arr[j]+" ";
		  maxProd=Math.Max(maxProd,prod);
		
		   Console.WriteLine("Subarray is "+subArr);
		  Console.WriteLine("product is  "+prod);
		 
		 Console.WriteLine("------------------------------");
		  
		
		
		    
		  }
		  
		  
		}
		 
		     Console.WriteLine("Max product is  "+ maxProd);
		
		}
	}
}