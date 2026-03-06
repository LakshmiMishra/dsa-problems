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
		  //2.	Devise an algorithm to traverse only the even-indexed elements of an array
		 int[] initialArray = { 10, 20, 50, 60,100,56,-2,60,90,30 };
	int n=initialArray.Length;

		  Console.Write("[");
	
		for(int i=0;i<n;i=i+2){
		    Console.Write(initialArray[i]+" ");
	
		}	 Console.Write("]");
	    
	
	 }
	}
}