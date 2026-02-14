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
		 int[] arr = {2, 3, -8, 7,-1,-2};
			 int n= arr.Length;
       //TTwo Sum - Pair with given Sum -Brute Force Approach
        int target=5;
        for(int i=0;i<n;i++){
          for(int j=i+1;j<n;j++){
            if(arr[i]+arr[j]==target){
              Console.WriteLine("pair ({0},{1}) whose target sum is {2}",arr[i],arr[j],target);
              break;
            }
          }
        }
        //complexity O(n^2)

		}
	}
}