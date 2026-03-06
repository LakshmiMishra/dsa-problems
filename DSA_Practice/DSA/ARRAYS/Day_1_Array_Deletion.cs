using System;

class ArrayDeletion
{
    // Function → Delete from End
    static int[] DeleteFromEnd(int[] arr)
    {
        int n = arr.Length;

        // New array of size -1
        int[] newArr = new int[n - 1];

        // Copy all except last
        for (int i = 0; i < n - 1; i++)
        {
            newArr[i] = arr[i];
        }

        return newArr;
    }

    // Function → Delete from Start
    static int[] DeleteFromStart(int[] arr)
    {
        int n = arr.Length;
        int[] newArr = new int[n - 1];

        // Shift elements left
        for (int i = 1; i < n; i++)
        {
            newArr[i - 1] = arr[i];
        }

        return newArr;
    }

    // Function → Delete from Given Position
    static int[] DeleteFromPosition(int[] arr, int position)
    {
        int n = arr.Length;
        int[] newArr = new int[n - 1];

        // Copy before position
        for (int i = 0; i < position; i++)
        {
            newArr[i] = arr[i];
        }

        // Shift after position
        for (int i = position + 1; i < n; i++)
        {
            newArr[i - 1] = arr[i];
        }

        return newArr;
    }

    // Print function
    static void PrintArray(int[] arr)
    {
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    // Main Driver
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Original Array:");
        PrintArray(arr);

        // Delete from End
        int[] endDelete = DeleteFromEnd(arr);
        Console.WriteLine("\nAfter Deletion from End:");
        PrintArray(endDelete);

        // Delete from Start
        int[] startDelete = DeleteFromStart(arr);
        Console.WriteLine("\nAfter Deletion from Start:");
        PrintArray(startDelete);

        // Delete from Position (index 2)
        int[] midDelete = DeleteFromPosition(arr, 2);
        Console.WriteLine("\nAfter Deletion from Position 2:");
        PrintArray(midDelete);
    }
}
