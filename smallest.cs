//*Q1) program to find smallest number in an array
using System;

class smallest
{
    static void Main()
    {
        int[] arr = { 10, 22, 553, 64, 5 };
        int smallest = arr[0]; // Assume the first element is the smallest

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < smallest)
            {
                smallest = arr[i]; // Update smallest if a smaller value is found
            }
        }

        // Print the smallest value after the loop
        Console.WriteLine("Smallest element in array: " + smallest);
    }
}
