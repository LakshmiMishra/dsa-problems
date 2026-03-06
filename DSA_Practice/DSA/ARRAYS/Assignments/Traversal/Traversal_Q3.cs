using System;


namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
		//3.	Create a method to traverse an array using recursion.
		 int[] initialArray = { 10, 20, 50, 60,100,56,-2,60,90,30 };
    
		  Console.Write("[");
		
	    printArrayRecursion(initialArray,0);
	   
	   Console.Write("]");
	    
	
	 }
	 static void printArrayRecursion(int[] arr,int index){
	   if(index==arr.Length)
	 return;
	   Console.Write(arr[index]+" ");
	   
	   printArrayRecursion(arr,index+1);
	 }
	}
}