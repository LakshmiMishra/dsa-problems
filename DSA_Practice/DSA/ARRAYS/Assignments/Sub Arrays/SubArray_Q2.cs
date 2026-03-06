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
			//print all subarrays optimized version O(n^2)
			int[] arr={1,2,8,3,4,6};
			int n=arr.Length;
		
			
			for(int i=0;i<n;i++ )
			{	
			  string subarr="";
			    
			    for(int j=i;j<n;j++){
			   
			    subarr=subarr+arr[j]+" ";
			    Console.WriteLine(subarr);
			    }

			  }
			  
			}
		
		
	}
}