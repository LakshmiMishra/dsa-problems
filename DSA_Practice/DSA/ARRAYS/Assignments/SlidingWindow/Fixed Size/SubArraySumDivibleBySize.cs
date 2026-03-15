using System;
					
public class Program
{
	
	  /* 7. Check if a Subarray of Size K Exists with Sum Divisible by K
Problem Statement:
Given an array of integers and an integer K, determine whether there exists at least one 
contiguous subarray of size K such that the sum of its elements is divisible by K.
Input:
Array = [2, 3, 4, 1, 5]
K = 3
Output:
Yes

		*/

	public static void Main()
	{
		int[] arr={2, 3, 4, 1, 5};
		
		int size=3;
	
		//subarray,check sum divisible, size K --> sliding window fixed size
		if(size>0){
		bool ifExists = subArraySumDivBySize(arr,size);
		Console.Write("{0}",ifExists);
		}
		else
				Console.Write("Size of Subarray should be greater than zero");
	}
	public static bool subArraySumDivBySize(int[] arr,int size){
		int n=arr.Length;
	
		//find first window sum
		int wSum=0;
		if(n<size)
			return false;
		else{
				for(int i=0;i<size;i++){
				wSum+=arr[i];
				}
				if((wSum%size)==0)
				return true;
		
				//slide the window 
				for(int i=size;i<n;i++)
					{
					wSum+=arr[i]-arr[i-size];	
						if((wSum%size)==0)
						return true;

					}
			}
		
		return false;
		
	}
	}
