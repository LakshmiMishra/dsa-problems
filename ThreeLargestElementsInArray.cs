using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program{
  public static void Main(string[] args){
   
   int[] arr={8,8,8,8,8};
   int fl=int.MinValue;
   int sl=int.MinValue;
   int tl=int.MinValue;
   
   if(arr.Length>2){
   for(int i=0;i<arr.Length;i++){
    
    if(fl!=arr[i]){
          if(fl<arr[i]) 
          {
            tl=sl;
            sl=fl;
            fl=arr[i];
          }
          else if(fl>arr[i] && sl<arr[i]){
            tl=sl;
            sl=arr[i];
          }
          else if( sl>arr[i] && tl<arr[i]){
            tl=arr[i];
          }
    }
   

   }
  List<int> res=new List<int>();
  
   if(fl!=int.MinValue)
   res.Add(fl);
   if(sl!=int.MinValue) 
   res.Add(sl);
   if(tl!=int.MinValue)
   res.Add(tl);
  
    foreach(var a in res){
      Console.WriteLine(a);
    }
   }
   else{
    Console.WriteLine("Array size should be 3 or gretar than 3 to find top three elements");
  }
    
  }
  
  
}