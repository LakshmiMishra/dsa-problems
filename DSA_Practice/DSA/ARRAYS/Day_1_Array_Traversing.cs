using System;

class ArrayTraversalAllWays
{
    // Recursive Traversal Function
    static void RecursiveTraversal(int[] arr, int index)
    {
        if (index == arr.Length)
            return;

        Console.Write(arr[index] + " ");
        RecursiveTraversal(arr, index + 1);
    }

    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };

        // 1. Traversal using FOR loop
        Console.WriteLine("1. Traversal using FOR loop:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine("\n");

        // 2. Traversal using WHILE loop
        Console.WriteLine("2. Traversal using WHILE loop:");
        int j = 0;
        while (j < arr.Length)
        {
            Console.Write(arr[j] + " ");
            j++;
        }
        Console.WriteLine("\n");

        // 3. Traversal using DO-WHILE loop
        Console.WriteLine("3. Traversal using DO-WHILE loop:");
        int k = 0;
        do
        {
            Console.Write(arr[k] + " ");
            k++;
        }
        while (k < arr.Length);
        Console.WriteLine("\n");

        // 4. Traversal using FOREACH
        Console.WriteLine("4. Traversal using FOREACH:");
        foreach (int value in arr)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine("\n");

        // 5. Reverse Traversal
        Console.WriteLine("5. Reverse Traversal:");
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine("\n");

        // 6. Recursive Traversal
        Console.WriteLine("6. Recursive Traversal:");
        RecursiveTraversal(arr, 0);
        Console.WriteLine("\n");

        // 7. Traversal using Array.ForEach()
        Console.WriteLine("7. Traversal using Array.ForEach():");
        Array.ForEach(arr, element =>
        {
            Console.Write(element + " ");
        });
        Console.WriteLine("\n");

        // 8. Traversal using GetLength()
        Console.WriteLine("8. Traversal using GetLength():");
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
