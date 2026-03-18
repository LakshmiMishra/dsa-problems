using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{/// edit this code to find the maximum element in every window of size K
	public class Program
	{
		public static void Main(string[] args)
		{//Maximum Element in Every Window of Size K
    // int [] arr={12, -1, -7, 8, -15, 30, 16, 28};
     //o/p should be [12,8,8,30,30,30]
    // int [] arr={1, 3, -1, -3, 5, 3, 6, 7};
     int[] arr={1,-1};
	   int n=arr.Length;
	   List<int> list=new List<int>();
		 int k=1;
		 int cmax=arr[0];

		 if(n>0)
		 list.Add(cmax);
		
		//Size K , Subarray sliding window fixed Size
	int slow=0;
	for(int fast=slow+1;fast<n;fast++){
	   
	    cmax=Math.Max(cmax,arr[fast]);
	  //check when the window size becomes K
	  if(fast-slow+1==k)//when the window equals to k size
    { 
     
      list.Add(cmax);//adding the max value of the window
      slow++;
      fast--;
      cmax=arr[slow];//max next csumto first value of window
    }
  
	  
	}
		foreach(var av in list){
		  Console.Write(av+" ");
		}
		}
	}
}