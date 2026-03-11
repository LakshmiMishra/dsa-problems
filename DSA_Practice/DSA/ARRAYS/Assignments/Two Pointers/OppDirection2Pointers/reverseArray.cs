using System;

public class Program
{
    public static void Main()
    {
        int[] arr = { 4, 6, 2, 7, 8, 9, 5 };
        ReverseArray(arr);
        PrintArray(arr);
    }
    
    public static void ReverseArray(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;
        
        while (left < right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
            left++;
            right--;
        }
    }
    
    public static void PrintArray(int[] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
            if (i < arr.Length - 1)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine("]");
    }
}