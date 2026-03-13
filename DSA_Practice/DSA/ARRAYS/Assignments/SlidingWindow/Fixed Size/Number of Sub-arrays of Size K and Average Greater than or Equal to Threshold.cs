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
	int[] arr={11,13,17,23,29,31,7,5,2,3};
	int k=3;
	
	int count=NumOfSubarrays(arr,3,5);
	Console.Write(count);
	
		  
		}
		

   public static int NumOfSubarrays(int[] arr, int k, int threshold) {
        int n=arr.Length;
         double windowSum=0.0;
         int counter=0;
         //calculate first window sum
         for(int i=0;i<k;i++){
            windowSum+=arr[i];
         }
         if((windowSum/k)>=threshold)
         { Console.WriteLine(windowSum/k);
         counter++;
         Console.WriteLine("count "+counter);
         }

         //using first window slide the window and find the sums
         for(int i=k;i<n;i++){
           windowSum+=arr[i]-arr[i-k];
           Console.WriteLine(windowSum/k);
            if((windowSum/k)>=threshold)
            {
               counter++;
                Console.WriteLine("count "+counter);
            }
         }
        return counter;//number of subarrays whose avereage is >=4
    }
}
	}
