using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
//5.	Formulate an approach to traverse an array and apply a transformation to each element.
namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{

		 int[] initialArray = { 10, 20, 50, 60,100,56,-2,60,90,30 };
    int n=initialArray.Length;
    	Console.WriteLine("Transformed Array though direct modification:");
		  Console.Write("[");
	
	   for(int i=0;i<n;i++){
	     Console.Write(initialArray[i]*2+" ");
	   }
	   Console.WriteLine("]");
	    
	  	Console.WriteLine("Transformed Array though Linq :");
		  Console.Write("[");
	int[] newArr=initialArray.Select(x=>x*2).ToArray();
	    for(int i=0;i<n;i++){
	     Console.Write(newArr[i]+" ");
	   }
	   Console.Write("]");
	
	 }
	
	}
}