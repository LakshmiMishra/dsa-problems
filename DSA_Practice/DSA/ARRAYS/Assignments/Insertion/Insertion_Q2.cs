//Elaborate a function to embed an element at a specified locus in a given array.
using System;
using System.Collections.Generic;


class EmbedElementInArray
{
    public static void Main(string[] args)
    {
   ////Example: Insert 30 into [10, 20, 40, 50] → Result: [10, 20, 30, 40, 50]
   //since this is a sorted array//find the middle of the array
   //then check the element needs to be inserted right or left.
   //binary tree search 

   int[] arr={10,20,30,40,50,60,90};
   int insertEle=20;
   int size=arr.Length;
   
   int position=BinarySearchRecursion(arr,insertEle);
   Console.Write("Position "+position);
   int[] newArr=new int[size+1];
  if(position==0){
    newArr[0]=insertEle;
    for(int i=0;i<size;i++){
      newArr[i+1]=arr[i];
    }
    
  }
   if(position==size){
     for(int i=0;i<size;i++){
       newArr[i]=arr[i];
     }
     newArr[size]=insertEle;
   }
   
   if(position>0 && position<size){
     for(int i=0;i<position;i++){
       newArr[i]=arr[i];
     }
     newArr[position]=insertEle;
     for(int i=position;i<size;i++){
       newArr[i+1]=arr[i];
     }
   }
   
   Console.Write("[");
    foreach(int e in newArr){
     
       Console.Write(e+",");
      
     }  Console.Write("]");
    }
 static int BinarySearchRecursion(int[] arr, int element)
    {
        int left = 0;
        int right = arr.Length - 1;
        
        // Binary search to find correct insertion position
        while(left <= right)
        {
            int midIndex = (left + right) / 2;
            
            if(arr[midIndex] == element)
                return midIndex;  // Element already exists
            
            if(arr[midIndex] > element)
                right = midIndex - 1;  // Search left half
            else
                left = midIndex + 1;   // Search right half
        }
        return left;  // Correct insertion position
    }
       
    }
