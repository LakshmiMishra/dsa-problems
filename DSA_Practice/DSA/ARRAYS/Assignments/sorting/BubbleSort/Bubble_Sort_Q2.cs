using System;
using System.Collections.Generic;
using System.Linq;


namespace HelloWorld
{
	public class Program
	{  
		public static void Main(string[] args)
		{
//Bubble Sort 2.	reverse the bubble sort algorithm to sort an array of integers in descending order.
		int[] arr1 = { 10,45,68,30, 50, 25,-1,70,90};
//	int[] arr1={2,3,4,5,6};
		 int n=arr1.Length;


	  		 //compare the adjacent elements and swap them if needed
      for(int i=0;i<n-1;i++){
        bool swap=false;
        for(int j=0;j<n-i-1;j++){
          int temp;
          if(arr1[j]<arr1[j+1])
          {
            temp=arr1[j];
            arr1[j]=arr1[j+1];
            arr1[j+1]=temp;
            swap=true;
          }
         
        }
        //check if there is atleast one swap
        if(!swap)
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