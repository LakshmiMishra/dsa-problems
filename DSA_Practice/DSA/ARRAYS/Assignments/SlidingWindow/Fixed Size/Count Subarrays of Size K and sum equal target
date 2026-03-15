using System;
					
public class Program
{
	
	  /* Count Subarrays of Size K with Sum Equal to X
			Problem Statement:
			You are given an array of integers, an integer K, and a target value X. Count the number of contiguous subarrays of size exactly K whose elements add up to X.
			Input:
			Array = [1, 2, 3, 1, 1, 1, 1]
			K = 3
			X = 6
			Output:
				2 
		*/

	public static void Main()
	{
		int[] arr={1,2,8,3,6,2,3,1,2,3,1,1,4,3,0,3};
		
		int size=3;
		int targetSum= 6;
		//subarray, count, size K --> sliding window fixed size
		int count=CountSubArrays(arr,targetSum,size);
		Console.Write(count >-1? "Number of subarrays whose size is "+size +"and target sum is "+targetSum+ " is -- "+count : "Array size is less than subarray size requested" );
	}
	public static int CountSubArrays(int[] arr,int target,int size){
		int n=arr.Length;
		int counter=0;
		//find first window sum
		int wSum=0;
		if(n<3)
			return -1;
		else{
				for(int i=0;i<size;i++){
				wSum+=arr[i];
				}
				if(wSum==target)
					counter++;
		
				//slide the window 
				for(int i=size;i<n;i++)
					{
					wSum+=arr[i]-arr[i-size];	
						if(wSum==target)
						counter++;

					}
			}
		
		return counter;
		
	}
	}
