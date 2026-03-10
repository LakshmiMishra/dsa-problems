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
			// 2 sum optimal approch for sorted array
			// we can use 2 pointesrs method here
			//O(n)
			//doenot work for unsorted array
			int[] arr={2,7,11,15};
			int target=9;
			int n=arr.Length;
			bool found=false;
			int start=0;
			int end= n-1;
			
			while(start<end){
			  int curSum=arr[start]+arr[end];
			  if(curSum==target)
			  {
			    found=true;
			    break;
        }
			  else if(curSum>target)
			  {
			    end--;
			  }
			  else
			  start++;
			}
			
				if(found){
			   Console.WriteLine("1-based indices whose sum is equal to {0} are [{1},{2}]",target,
			      start+1,end+1);
			
			}
			else
			  Console.Write("No pair exists");
			  
		}
	}
}