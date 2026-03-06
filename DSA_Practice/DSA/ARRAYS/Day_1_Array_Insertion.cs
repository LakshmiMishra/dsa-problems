using System;

class ArrayInsertion
{
    // Function → Insert at End
    static int[] InsertAtEnd(int[] arr, int newValue)
    {
        int n = arr.Length;

        // Create new array of size +1
        int[] newArr = new int[n + 1];

        // Copy old elements
        for (int i = 0; i < n; i++)
        {
            newArr[i] = arr[i];
        }

        // Insert at end
        newArr[n] = newValue;

        return newArr;
    }

    // Function → Insert at Start
    static int[] InsertAtStart(int[] arr, int newValue)
    {
        int n = arr.Length;
        int[] newArr = new int[n + 1];

        // Shift elements right
        for (int i = 0; i < n; i++)
        {
            newArr[i + 1] = arr[i];
        }

        // Insert at start
        newArr[0] = newValue;

        return newArr;
    }

    // Function → Insert at Given Position
    static int[] InsertAtPosition(int[] arr, int newValue, int position)
    {
        int n = arr.Length;
        int[] newArr = new int[n + 1];

        // Copy before position
        for (int i = 0; i < position; i++)
        {
            newArr[i] = arr[i];
        }

        // Insert element
        newArr[position] = newValue;

        // Shift remaining elements
        for (int i = position; i < n; i++)
        {
            newArr[i + 1] = arr[i];
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
        // Array of size 5 with 5 elements
        int[] arr = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Original Array:");
        PrintArray(arr);

        // Insert at End
        int[] endInsert = InsertAtEnd(arr, 60);
        Console.WriteLine("\nAfter Insertion at End:");
        PrintArray(endInsert);

        // Insert at Start
        int[] startInsert = InsertAtStart(arr, 5);
        Console.WriteLine("\nAfter Insertion at Start:");
        PrintArray(startInsert);

        // Insert in Between (position 2 → index based)
        int[] midInsert = InsertAtPosition(arr, 25, 2);
        Console.WriteLine("\nAfter Insertion at Position 2:");
        PrintArray(midInsert);
    }
}
