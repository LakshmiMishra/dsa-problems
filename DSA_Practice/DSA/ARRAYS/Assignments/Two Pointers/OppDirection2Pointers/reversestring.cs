using System;

public class Program
{
    public static void Main()
    {
    string s="iamawesome";
    char[] arr=s.ToCharArray();
     int start=0;
     int end=arr.Length-1;
     while(start<end){
    char temp=arr[start];
      arr[start]=arr[end];
      arr[end]=temp;
      start++;
      end--;
      
     }
     string str=new string(arr);
      Console.Write("Reverese String is {0}",str);
    }  
    
   
  
}
    