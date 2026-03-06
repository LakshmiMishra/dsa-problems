//5.	Formulate an approach to traverse an array and apply a transformation 
//to each element.

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
//5.	Formulate an approach to traverse an array and apply a transformation to each element.
		 int[] initialArray = { 10, 20, 50, 60,100,56,-2,60,90,30 };
       int n=initialArray.Length;
    	Console.WriteLine("Transformed Array though generic functionn:");
	
	    	int[] doubled= TransformArray(initialArray,x=>x*2);
	  	printArray(doubled,n);
	  
	  	int[] squared= TransformArray(initialArray,x=>x*x);
	  	printArray(squared,n);
		  
		  	int[] halved= TransformArray(initialArray,x=>x/2);
	  	printArray(halved,n);
		  
	 }
	 
	 static int[] TransformArray(int[] array,Func<int,int> transform ){
	   return array.Select(transform).ToArray();
	   
	   
	 }
	 static void printArray(int[] arr,int n){
	   Console.Write("[");

	    for(int i=0;i<n;i++){
	     Console.Write(arr[i]+" ");
	   }
	   Console.WriteLine("]");
	
	 }
	 
	 
	
	}
}