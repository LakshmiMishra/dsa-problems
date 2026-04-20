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
             int  k=5;                                                                                                                         
		  int n=WaysOfClimbingStairs(k);
		  Console.Write("Climbing  ways for {0} stairs is {1}",k,n);
	
			
		}
		static int WaysOfClimbingStairs(int n){
		  if(n<=2)
		  return n;
		  		int[] F= new int[n+1];
		  		F[0]=-1;
		  		F[1]=1;
		  		F[2]=2;
		  		//only climbing 1 or 2 stairs are allowed 
		  		for(int i=3;i<=n;i++)
		  		{
		  		  F[i]=F[i-2]+F[i-1];
		  		}
		  return F[n];
		}
	}
}