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
			//1.	Compose a function to find the maximum sum subarray
			//Input: arr[] = [2, 3, -8, 7, -1, 2, 3]
      //Output: 11
      //Explanation: The subarray [7, -1, 2, 3] has the largest sum 11.
  // find all sub arrays and there sum
    // O(n^2) O(1)
    int[] arr={2, 3, -8, 7, -1, 2, 3};
    int maxSum=int.MinValue;
    
    int n= arr.Length;
    for(int i=0;i<n;i++)//outer loop
    
    {
      int curSum=0;
      string arr1="";
      for(int j=i;j<n;j++)// check sum of all sub arrays one by one and compare it wth max sum
      
      {
       arr1+=arr[j]+" ";
       Console.WriteLine(arr1+" ");
   
        curSum=curSum+arr[j];
         Console.WriteLine("sum of this sub array is "+curSum);
        
      }
      maxSum=Math.Max(curSum,maxSum);
   
    }
     Console.WriteLine("max sum of sub array in this array is  "+maxSum);
      
		}
	}
}