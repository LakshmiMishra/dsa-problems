//1.	Binary search for an element in a sorted array
//Given a sorted array and an element, use binary search to find the index of the element.
using System;
using System.Collections.Generic;
using System.Linq;


namespace HelloWorld
{
	public class Program
	{  
		public static void Main(string[] args)
		{
//1.	Binary search for an element in a sorted array
//Given a sorted array and an element, 
//use binary search to find the index of the element.

		int[] arr1 = { -1,0,20,40,60,89,99,100};
    int targetEle=60; 
		 int n=arr1.Length;
		if(arr1==null || arr1.Length==0)
		{
		  
		  Console.Write("Empty array");
		  
		}
	else
	{
	  int result=BinarySearchElementIndex(arr1,targetEle);
	  if(result==-1)
	  		  Console.Write("Element not found");
	  		  else
	  		  
	  Console.Write("Index of the element is :"+ result);

	}
  
		
		 }
		 
	static int BinarySearchElementIndex(int[] arr1, int targetEle){
	  
	 
	  int start=0;
	  int end =arr1.Length-1;;
	  
	  
	  while(start<=end){
	    int mid=(start+end)/2;
	    if(arr1[mid]==targetEle)
	    return mid;
	    
	    if(arr1[mid]<targetEle)
	    {
	      start=mid+1;
	    }
	    else
	    {
	    end =mid-1;
	    }
	    
	  }
	  
	  return -1;
	}
	

	
	 
	
	}
}