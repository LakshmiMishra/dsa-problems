using System;
using System.Collections.Generic;
using System.Linq;


namespace HelloWorld
{
	public class Program
	{  
		public static void Main(string[] args)
		{
//	3.	Devise a method to delete an element from a sorted array and maintain order.
///Complexity O(n) since we need to traverse the array to find the element and then delete it by shifting elements to left
/// although binary search takes On(logn ) to find the element, overall complexity is O(n) since we need to shift elements to left after deletion
/// 

		 int[] arr = { 10, 20,30, 50, 60,100,180,200,240 };
      int n=arr.Length;
      int target=30;
      
      //since array is sorted, we can use binary search to locate the element and delete
      
      int index=BinarySearchElement(arr,target,0,n-1);
      
// delete element at index.
  if(arr==null || arr.Length==0)
	   Console.Write("Empty Array");
       else deleteArrayElement(arr,index);
        
    
	 }
	 static void deleteArrayElement(int[]arr ,int index){
	   int n=arr.Length;
	 
	   
	   {
	      int[] newarr= new int[n-1];
	     if(index==0){
	       //delete at the start
	      for(int i=0;i<n-1;i++){
	        newarr[i]=arr[i+1];
	       
	      }
	      printArray(  newarr,n-1);
	     }
	      if(index==n-1){
	       //delete at the end
	      for(int i=0;i<n-1;i++){
	        newarr[i]=arr[i];
	       
	      }
	      printArray(  newarr,n-1);
	     }
	      if(index>0 && index<n-1){
	       //copy till index
	      for(int i=0;i<index;i++){
	        newarr[i]=arr[i];
	       
	      }
	      //
	       for(int i=index;i<n-1;i++){
	        newarr[i]=arr[i+1];
	       
	      }
	      
	      printArray(  newarr,n-1);
	     }
	   }
	   
	   
	 }
	 static int BinarySearchElement(int[] arr, int element,int start1, int end1){
	   
	   int start=start1;
	   int end= end1;
	  
	   int mid=(start+end)/2;
	   if(arr[mid]==element)
	   return mid;
	   else if(arr[mid]>element){
	     return BinarySearchElement( arr,element,start,mid-1);
	   }
	   else {
	    return BinarySearchElement( arr ,element,mid+1,end);
	   }
	    if(start>end)
	   return -1;
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