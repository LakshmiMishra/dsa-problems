using System;

class SearchingAllWays
{
    // ---------------- LINEAR SEARCH (ITERATION) ----------------
    static int LinearSearchIterative(int[] arr, int key)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == key)
                return i;
        }
        return -1;
    }

    // ---------------- LINEAR SEARCH (RECURSION) ----------------
    static int LinearSearchRecursive(int[] arr, int key, int index)
    {
        if (index >= arr.Length)
            return -1;

        if (arr[index] == key)
            return index;

        return LinearSearchRecursive(arr, key, index + 1);
    }

    // ---------------- BINARY SEARCH (ITERATION) ----------------
    static int BinarySearchIterative(int[] arr, int key)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] == key)
                return mid;

            else if (arr[mid] < key)
                left = mid + 1;

            else
                right = mid - 1;
        }

        return -1;
    }

    // ---------------- BINARY SEARCH (RECURSION) ----------------
    static int BinarySearchRecursive(int[] arr, int key, int left, int right)
    {
        if (left > right)
            return -1;

        int mid = (left + right) / 2;

        if (arr[mid] == key)
            return mid;

        else if (arr[mid] < key)
            return BinarySearchRecursive(arr, key, mid + 1, right);

        else
            return BinarySearchRecursive(arr, key, left, mid - 1);
    }

    // ---------------- MAIN ----------------
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 }; // Sorted for Binary Search
        int key = 30;

        Console.WriteLine("Array Elements:");
        foreach (int i in arr)
            Console.Write(i + " ");

        Console.WriteLine("\n\nSearching element: " + key);

        // Linear Search Iterative
        int linIter = LinearSearchIterative(arr, key);
        Console.WriteLine("\nLinear Search (Iterative) Index: " + linIter);

        // Linear Search Recursive
        int linRec = LinearSearchRecursive(arr, key, 0);
        Console.WriteLine("Linear Search (Recursive) Index: " + linRec);

        // Binary Search Iterative
        int binIter = BinarySearchIterative(arr, key);
        Console.WriteLine("\nBinary Search (Iterative) Index: " + binIter);

        // Binary Search Recursive
        int binRec = BinarySearchRecursive(arr, key, 0, arr.Length - 1);
        Console.WriteLine("Binary Search (Recursive) Index: " + binRec);
    }
}
