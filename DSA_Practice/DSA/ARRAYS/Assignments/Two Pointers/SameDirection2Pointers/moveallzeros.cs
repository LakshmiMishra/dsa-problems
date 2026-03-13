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
		  //Move All zeros to end
		  int[] arr={1,0,3,4,0,6,0,4};
		  int slow=0;

		  for(int fast=0;fast<arr.Length;fast++){
		    
		    if(arr[fast]!=0)
		    {
		     int temp=arr[slow];
		     arr[slow]=arr[fast];
		     arr[fast]=temp;
		     slow++;
		      
		    }
		 
		    
		  }
		  for(int i=0;i<arr.Length;i++){
		    Console.Write(arr[i]+" ");
		  }
	
		}
		static void Swap(int a,int b){
		  int temp=a;
		  a=b;
		  b=temp;
		}
	}
}