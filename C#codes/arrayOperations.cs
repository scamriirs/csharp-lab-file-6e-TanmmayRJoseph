using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] *= 7;
        }

        int sumOddIndex = 0;
        for (int i = 1; i < arr.Length; i += 2)
        {
            sumOddIndex += arr[i];
        }


        Console.WriteLine("Array elements after multiplication by 7 is: " + string.Join(", ", arr));
        Console.WriteLine("Sum of elements at odd indices: " + sumOddIndex);
    }
}