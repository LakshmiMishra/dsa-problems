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
	
			int[] arr={-1,-1,-2,0,1,1,8,8,2,-1,3,3,8,4,4,9,4,5};
			List<int> uniqueElements=new List<int>();
			//unsorted array
			//remove dupliactes
			//first sort array and then remove dupliactes
			//O(n^2)
			Array.Sort(arr);
			uniqueElements.Add(arr[0]);
			for(int i=0;i<arr.Length-1;i++){
			  
  			 if(arr[i]!=arr[i+1])
  			 {
  			   uniqueElements.Add(arr[i+1]);
  			 }
	     	}
	     	Console.Write("[");
			  foreach(int a in uniqueElements){
			    Console.Write(a+",");
			  }
			      	Console.Write("]");
			}
		}
	}


///Another way
/// O(n^2) time complexity and O(n) space complexity
/// using System;
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
		
			//unsorted array
			//remove dupliactes
			//O(n^2)
     List<int> uniqueEleArray=new List<int>();
     
			for(int i=0;i<arr.Length-1;i++){
			  bool found=false;
			  for(int j=0;j<uniqueEleArray.Count;j++){
			    
			    //check where the arry elem is present in uniqueEleArray
			    //if yes then the element is found 
			    //berak
			    if(arr[i]==uniqueEleArray[j])
			    {
			      found=true;
			      break;
			    }
			  }
			  if(!found){
			    uniqueEleArray.Add(arr[i]);
			  }
  		
			}
		Console.Write("[");
			  foreach(int a in uniqueEleArray){
			    Console.Write(a+",");
			  }
			      	Console.Write("]");
			}
	  
	}
	}
