using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
//1.	Elaborate a function to traverse an array in reverse order.
namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
		 int[] initialArray = { 10, 20, 50, 60,100,56,-2 };
		 Console.WriteLine(initialArray.Length-1);
		
		  Console.Write("[");
	
		for(int i=initialArray.Length-1;i>=0;i--){
		    Console.Write(initialArray[i]+" ");
	
		}	 Console.Write("]");
	    
	
	 }
	}
}