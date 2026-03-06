using System;
using System.Collections.Generic;
using System.Linq;


namespace HelloWorld
{
	public class Program
	{  public static int counter = 0;
		public static void Main(string[] args)
		{
//	2.	Create an algorithm to remove all instances of a specified value from an array.
		 int[] arr = { 10, 20,30, 50, 60,100,30,56,-2,60,90,30 };
       int n=arr.Length;
    
       int deleteAll=60;//change the deleteAt value to test different outputs
    	int[] newArr={};
    	if(arr==null || arr.Length==0)
    	{
    	Console.Write("Empty Array");
    
    	}
    	else
    	{
     newArr= arr.Where(x=> x!=deleteAll).ToArray();
       printArray(newArr,newArr.Length);
    	}
		 
		 //Complexity O(n)
		 
		 //uisng List
		 int delete=30;
		 	if(newArr==null || newArr.Length==0){
		 	 	Console.Write("Empty Array");
		 	 	
		 	}
		 	else{
   
		 List<int> list=new List<int>(newArr);
		 list.RemoveAll(x=>x==delete);
	  	printArray(list.ToArray(),list.Count());
		 	}
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