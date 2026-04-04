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
			int[] arr={1,2,3,4};
			int n= arr.Length;
			int [] res=new int[arr.Length];
			
			for(int i=0;i<n;i++){
				  for(int j=0;j<n;j++){
			    
			    if(i!=j)
			    res[i]*=arr[j];
			  }
		 
			  Console.Write(res[i]+",");
			}
		}
	}
}