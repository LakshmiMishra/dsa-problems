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
	
			int[] arr={7,-1,-1,-2,0,1,1,8,8,2,-1,3,3,8,4,4,9,4,5};
		
		Dictionary<int,int> dic=new Dictionary<int,int>();
		
	//As we travese through array, we will store uniue elements in Dictionary
	
	for(int i=0;i<arr.Length-1;i++){
	  
	  if(!dic.ContainsKey(arr[i]))
	  {
	    dic.Add(arr[i],i);
	  }
	}
		Console.Write("[");
		foreach(KeyValuePair<int,int> ele in dic){
			    Console.Write(ele.Key+",");
			  }
			      	Console.Write("]");
		}
	  
	}
	}
