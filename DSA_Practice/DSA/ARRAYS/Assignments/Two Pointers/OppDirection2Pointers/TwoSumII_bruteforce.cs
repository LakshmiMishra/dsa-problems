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
			//2 sum brute force  find all the pairs whose sum is equal to target
			int[] arr={2,7,11,15};
			int target=9;
			int n=arr.Length;
			bool found=false;
			int index1=-1;
			int index2=-1;
			//find all the pairs 
			for(int i=0;i<n;i++){
			  int curSum=0;
			  for(int j=i+1;j<n;j++){
			    curSum=arr[i]+arr[j];
			    if(curSum==target)
			    {
			     found=true;
			     index1=i+1;
			     index2=j+1;
			    }
			 
			}
		
			}
				if(found){
			   Console.WriteLine("1-based indices whose sum is equal to {0} are {1},{2}",target,
			      index1,index2);
			
			}
			else
			  Console.Write("No pair exists");
			  
		}
	}
}