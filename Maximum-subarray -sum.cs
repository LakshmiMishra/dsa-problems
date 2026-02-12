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
			int[] arr={2, 3, -8, 7, -1, 2, 3};
			int res=arr[0];
			
			//we will use 2 nested for loops
			//outer loop for travesing the array
			//inner loop will find the sum of sub array
			
			for(int i=0;i<arr.Length;i++)
			{
			  int subArraySum=0;
			  //sub arrays starting from ith index
			  for(int j=i;j<arr.Length;j++){
			    subArraySum=subArraySum+arr[j];
			    
			   // i=0
			    // sum=0+5;
			    //sum=5+7;
			    //sum=5+7-1;
			    //sum =5+7-1+8;
			    //sum=5+7-1+8+2;
			  //  we will always compare the sum with theinital result.If it is greater than intial resul then it will be replaced
			    res=Math.Max(res,subArraySum);
			    //i=1
			    //sum=0+7=7;
			    //sum=7-1=6;
			    //sum=7-1+8;
			    //sum=7-1+8+2
			    
			    
			  }
			}
			Console.Write(res);
		}
	}
}