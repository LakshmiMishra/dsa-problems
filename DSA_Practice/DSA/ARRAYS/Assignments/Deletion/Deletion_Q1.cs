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
//	Compose a function to excise an element from a given index in an array.
		 int[] initialArray = { 10, 20, 50, 60,100,56,-2,60,90,30 };
       int n=initialArray.Length;
       int[] newArr=new int[n-1];
       int deleteAt=5;//change the deleteAt value to test different outputs
    	if(deleteAt<0 || deleteAt>=n){
    	   Console.WriteLine("Invalid index to delete");
    	   return;
    	}
    	if(deleteAt==0){
    	  	for(int i=0;i<n-1;i++){
    	  newArr[i]=initialArray[i+1];
    	
    	  	}
    	  	 
    	}
    	if(deleteAt>0 && deleteAt<n)
    	{
    	  //copy the prev element from old arry to new array
    	  for(int i=0;i<deleteAt;i++){
    	    newArr[i]=initialArray[i];
    	  }
    	  //delete the element  at deteleAt index and copy the rest elements from old array to 
    	  //new array
    	  for(int i=deleteAt;i<n-1;i++){
    	    newArr[i]=initialArray[i+1];
    	  }
    	  
    	}
      if(deleteAt==n-1){
            for(int i=0;i<n-1;i++){
                newArr[i]=initialArray[i];
            }
        }
    	 printArray(newArr,n-1);
		  
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