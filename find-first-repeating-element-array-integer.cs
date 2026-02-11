using System;
using System.Collections.Generic;
class Program{
  
  public static void Main(string[] args){
    int[] arr={7,8,9,9,9,0,0};
    bool repeat=false;
     Dictionary<int,int> dict=new Dictionary<int,int>();// Dictionary for storing key and value of array
     //dictionary stores uniue values
     
     for(int i=0;i<arr.Length;i++){
       if(dict.ContainsKey(arr[i])){
         Console.WriteLine("{0} is a first repeating element in the array.{1} is the index for it.",arr[i],i);
         repeat=true;
         break;
       }
       else
       {
         dict.Add(arr[i],i);
       }
       
     }
     if(!repeat)
     Console.WriteLine("no repeating elements in the array");
  }
  
  
}