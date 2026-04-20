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
		  int n=findFibbo(6);
		  Console.Write("Fibbonacci for {0} is {1}",6,n);
	
			
		}
		static int findFibbo(int n){
		  		int[] F= new int[n+1];
		  		F[0]=0;
		  		F[1]=1;
		  		
		  		for(int i=2;i<=n;i++)
		  		{
		  		  F[i]=F[i-2]+F[i-1];
		  		}
		  return F[n];
		}
	}
}