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
		int[] arr={1, 3, 2, 6, -1, 4, 1, 8, 2};

		int n=arr.Length;
	   List<double> list=new List<double>();
		int size=5;
		//Average of All Subarrays of Size K
		//Size K , Subarray sliding window fixed Size
		double avg=0.0;
		//first window
	  double wSum=0.0;

		for(int i=0;i<size;i++){
		  wSum+=arr[i];
		  
	}
	    avg=wSum/size;
		  list.Add(avg);
		//slide the first window and find all the sums for other windows
		for(int i=size;i<n;i++){
		  
		  wSum+=arr[i]-arr[i-size];
		  avg=wSum/size;
		  list.Add(avg);

		}
		foreach(double av in list){
		  Console.Write(av+" ");
		}
		}
	}
}