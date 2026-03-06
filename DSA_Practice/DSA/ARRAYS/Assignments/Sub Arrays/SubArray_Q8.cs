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
	//	4.	Write a function to find all subarrays with a given sum.
   int[] arr = {-10, -5, 8, 9, -6,3,0};
   int k=3;
    int n= arr.Length;
  
  //find all subarrays and check the sum 

        for(int i=0;i<n;i++){
          string sbarr="";
           int curSum=0; 
          for(int j=i;j<n;j++){
           
            sbarr+=arr[j]+" ";
            curSum+=arr[j];
           
            if(curSum==k)
            { Console.WriteLine("Sub Array is "+sbarr);
              Console.WriteLine("Sum of sub array ele is "+curSum);
            Console.WriteLine("--------------------------");
           
            }
         
          }
         
        }
      
   	}
	}
}