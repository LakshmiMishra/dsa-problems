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
			//print sum of all subarrays
			int[] arr={1,2,3,4};
			int n=arr.Length;
		
		  int totalsum=0;
      for(int i=0;i<n;i++){
        int sum=0;
        for(int j=i;j<n;j++){
          sum=sum+arr[j];
        totalsum=totalsum+sum;
        }
         
      }
		 Console.WriteLine(totalsum);
			}
		
		
	}
}