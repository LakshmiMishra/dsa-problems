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
    

    int[] arr={-4,-1,0,3,10};
   
   SquaresSortedArray(arr);

      
		}
		public static void SquaresSortedArray(int[] arr) {
		   int n=arr.Length;
		  int slow=0;
		  int fast=n-1;
		 int [] res=new int[n];
		  for(int i=n-1;i>=0;i--){
		    
		    if(Math.Abs(arr[fast])>Math.Abs(arr[slow])){
		      res[i]=arr[fast]*arr[fast];
		      fast--;
		    }
		    else
		    { 
		      res[i]=arr[slow]*arr[slow];
		      slow++;
		      
		    }
		  }
		  
		  for(int i=0;i<res.Length;i++){
		    Console.Write(res[i]+" ");
		  }
		
       }
      
	}
}