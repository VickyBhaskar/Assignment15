using System;

public class SortingAndSearching
{
    // Bubble Sort implementation for sorting an array in descending order
    public static void BubbleSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] < arr[j + 1])
                {
                    // Swap arr[j] and arr[j+1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // Method to generate a random array of integers
    public static int[] GenerateRandomArray(int size, int minValue, int maxValue)
    {
        int[] randomArray = new int[size];
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            randomArray[i] = random.Next(minValue, maxValue + 1);
        }

        return randomArray;
    }

    // Method to check if the array is sorted correctly in descending order
    public static bool IsSorted(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] < arr[i + 1])
            {
                return false;
            }
        }

        return true;
    }

    // Binary Search implementation
    public static int BinarySearch(int[] arr, int target)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] == target)
            {
                return mid; // Element found
            }
            else if (arr[mid] > target)
            {
                high = mid - 1; // Search in the left half
            }
            else
            {
                low = mid + 1; // Search in the right half
            }
        }

        return -1; // Element not found
    }

    // Main method for testing
    public static void Main()
    {
        // Generate a random array of integers
        int[] arrayToSort = GenerateRandomArray(10, 1, 100);

        Console.WriteLine("Original Array:");
        PrintArray(arrayToSort);

        // Apply Bubble Sort to sort the array in descending order
        BubbleSort(arrayToSort);

        Console.WriteLine("\nArray After Bubble Sort:");
        PrintArray(arrayToSort);

        // Check if the array is sorted correctly
        Console.WriteLine($"\nIs the array sorted correctly? {IsSorted(arrayToSort)}");

        // Binary Search example
        int targetValue = arrayToSort[3]; 
        int index = BinarySearch(arrayToSort, targetValue);

        Console.WriteLine($"\nBinary Search Result: Target value {targetValue} found at index {index}");
    }

    // Method to print an array
    public static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
