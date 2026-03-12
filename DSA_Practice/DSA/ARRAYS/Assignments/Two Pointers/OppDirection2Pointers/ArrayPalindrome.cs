using System;

public class Program
{
    public static void Main()
    {
      //arry is palindrome or not
      
      int[] arr={7,8,9,3,3,9,8,7};
      //2 pointer approch
      int start=0;
      int end=arr.Length-1;
      while(start<end){
        if(arr[start]==arr[end]){
          start++;
          end--;
        }
        else{
            Console.Write("It is not a Palindrome");
            return;
        }
   
      }
        Console.Write("It is a Palindrome");
        // O(n/2) time complexity, O(1) space complexity
  
    }  
    
   
  
}
    