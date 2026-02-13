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
		 int[] arr = {1,8,12,17,22};
			 int n= arr.Length;
       //TTwo Sum - Pair with given Sum -Two Pointer Approch
      // Given an array of integers numbers that is sorted in non-decreasing order.

        //Return the indices (1-indexed) of two numbers, [index1, index2], 
        //such that they add up to a given target number target and index1 < index2.
        //Note that index1 and index2 cannot be equal, therefore you may not use the same element twice.
        int target=34;
  
      //in this approach the array should be already sorted
      //take one pointer from start and one pointer from end
     // for i=0;and j=n;
      //sum=arr[i]+arr[j]; if sum>34 this means we need to decrease the right pointer to lower the sum value.
      //if sum< 34 then need to increment the left pointer to increase the sum value.
      
      //sum=1+22=23 <34
      //increase the left pointer 
      //sum=8+22=30<34
      //increase left pointer
      //sum= 12+22=34 =34 btrak;
      int leftIndex=0;
      int rightIndex=n-1;
      while(leftIndex<rightIndex)//alawyas checking that left index should be always less than right index
      {
        if(arr[leftIndex]+arr[rightIndex] >target)
        {rightIndex--;
        }
        else if(arr[leftIndex]+arr[rightIndex]<target){
         leftIndex++;
        }
        if(arr[leftIndex]+arr[rightIndex]==target){
          Console.WriteLine("the pair of array elements is ({0},{1}) whose target sum is {2}",arr[leftIndex],arr[rightIndex],target);
          Console.WriteLine("the pair for 1 based indices for the array element is ({0},{1}) whose target sum is {2}",leftIndex+1,rightIndex+1,target);
          break;
        }
       
      }
       
		}
	}
}