﻿
int[] arr = { 64, 25, 12, 22, 11 };
Sort(arr);
Console.WriteLine("Sorted array:");
PrintArray(arr);



// Function to perform selection sort
static void Sort(int[] arr)
{
    int n = arr.Length;

    // One by one move boundary of unsorted subarray
    for (int i = 0; i < n - 1; i++)
    {
        // Find the minimum element in unsorted array
        int min_idx = i;
        for (int j = i + 1; j < n; j++)
        {
            if (arr[j] < arr[min_idx])
            {
                min_idx = j;
            }
        }

        // Swap the found minimum element with the first element
        int temp = arr[min_idx];
        arr[min_idx] = arr[i];
        arr[i] = temp;
    }
}

// Function to print array
static void PrintArray(int[] arr)
{
    int n = arr.Length;
    for (int i = 0; i < n; ++i)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}