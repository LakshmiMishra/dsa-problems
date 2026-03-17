using System;

public class Program
{
    public static void Main()
    {
    string s="iamawesome";
     int start=0;
     int end=s.Length-1;
     while(start<end){
    char temp=s[start];
      s[start]=s[end];
      s[end]=temp;
      start++;
      end--; 
    }
      Console.Write("Reverese String is {0}",s);
    }  
    
   
  
}
    