using System;
using System.Collections.Generic;
using System.Linq;


namespace HelloWorld
{
	public class Program
	{  
		public static void Main(string[] args)
		{
//Bubble Sort 1.	Elaborate a function to perform bubble sort on an array of integers.

		int[] arr1 = { 10,45,68,30, 50, 25,-1,70,90};
//	int[] arr1={2,3,4,5,6};
		 int n=arr1.Length;

	for(int i=0;i<n;i++){
	  		 //compare the adjacent elements and swap them if needed
	bool flag=false;//reset flag for each pass
	  for(int j=0;j<n-i-1;j++)// After each pass one element is already sorted.
	  {
	    int temp;
	    if(arr1[j]>arr1[j+1]){
	    temp=arr1[j];
	    arr1[j]=arr1[j+1];
	    arr1[j+1]=temp;
	    flag=true;
	    }
	    
	  }
	  if(!flag)
	  break;
	  
	}
		
		 printArray(arr1,arr1.Length);
		
		 }
		 
	
	

	 static void printArray(int[] arr,int n){
	   Console.Write("[");

	    for(int i=0;i<n;i++){
	     Console.Write(arr[i]+(i<n-1?",":""));
	   }
	   Console.WriteLine("]");
	
	 }
	 
	 
	
	}
}