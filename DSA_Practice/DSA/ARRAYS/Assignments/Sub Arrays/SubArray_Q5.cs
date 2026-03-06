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
    
    int[] arr={2, 3, -8, 7, -1, 2, 3};
        int n= arr.Length;
   //kadane's algo
   //If the curren sum of the sub array is becoming negative
   // it will make the the max sum negative
   // so we will not consider that sub array and move forward 

     int maxSum=int.MinValue;
    int curSum=0;
     for(int i=0; i<n;i++)
     {
       

     curSum=curSum+arr[i];
     curSum=Math.Max(curSum,arr[i]);// Will check the current sum value should always be greater than the array element 
     Console.WriteLine("currentsum "+ curSum);
     maxSum=Math.Max(curSum,maxSum);
     
  if(curSum<0)
  curSum=0;
     
   }
   Console.Write("max subarray sum is "+maxSum);
      
		}
	}
}