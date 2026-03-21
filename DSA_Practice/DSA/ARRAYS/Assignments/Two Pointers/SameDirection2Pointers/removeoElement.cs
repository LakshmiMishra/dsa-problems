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
//             Q3. Remove all occurrences of a given element
// Problem Statement:
// Given an integer array and a value, remove all occurrences of that value in-place and return the new length.
// Input:
// arr = [3, 2, 2, 3], val = 3
// Output:
// 2

		
			  int[] nums = { 2, 2, 4,2, 3 ,5};
    int k = RemoveElement(nums, 2);
    Console.WriteLine($"k = {k}");
		}
		 public static int RemoveElement(int[] nums, int val) {
        int k = 0; 
        
        // 'i' is the pointer that iterates through the array
        for (int i = 0; i < nums.Length; i++) {
            // If the current element is not the value to be removed
            if (nums[i] != val) {
                // Place the current element at the 'k' position
                 nums[k] = nums[i];
                // Move 'k' forward to the next available position
                k++; 
            }
        }  Console.Write("[");
        for(int i=0;i<k;i++){
          Console.Write(nums[i]+" ");
        }
        Console.Write("]");
        // 'k' now represents the number of elements not equal to 'val'
        // and also the length of the modified array's relevant part.
        return k;
    }
	}
}