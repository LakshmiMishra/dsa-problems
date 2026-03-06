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
			//print all subarrays
			int[] arr={1,2,8,3,4,6};
			int n=arr.Length;
			
			for(int i=0;i<n;i++ )
			{
			  for(int j=i;j<n;j++){
			    
			    //print all the elements starting from i to j 
			    for(int k=i;k<=j;k++){
			      Console.Write(arr[k]+" ");
			    }
			    Console.WriteLine();
			  }
			  
			}
		}
	}
}