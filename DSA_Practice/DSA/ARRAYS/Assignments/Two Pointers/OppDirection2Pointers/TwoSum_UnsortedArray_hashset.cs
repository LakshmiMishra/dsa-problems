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
			// 2 sum optimal approch for unsorted array
			int[] arr={2,7,11,15};
			int target=9;
			int n=arr.Length;
			HashSet<int> hash = new HashSet<int>();

for(int i = 0; i < n; i++){
    int complement = target - arr[i];
    
    if(hash.Contains(complement)){
        Console.WriteLine($"Pair found: {complement} + {arr[i]} = {target}");
        return;
    }
    hash.Add(arr[i]);  // Add current element, not complement
}

Console.WriteLine("No pair exists");
			  
		}
	}
}