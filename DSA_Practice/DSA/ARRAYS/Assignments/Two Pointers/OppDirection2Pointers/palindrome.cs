using System;

public class Program
{
    public static void Main()
    {
        string input = "rachhcar";
        char[] chars = input.ToCharArray();
        
        if (IsPalindrome(chars))
        {
            Console.WriteLine("It's a palindrome");
        }
        else
        {
            Console.WriteLine("It's not a palindrome");
        }
    }
    
    public static bool IsPalindrome(char[] chars)
    {
        int left = 0;
        int right = chars.Length - 1;
        
        while (left <= right)
        {
            if (chars[left] != chars[right])
            {
                return false;
            }
            left++;
            right--;
        }
        
        return true;
    }
}