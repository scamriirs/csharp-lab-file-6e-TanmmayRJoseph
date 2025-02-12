//*Q1) write a program to find largest sequence of positive numbers in an array of integers

// using System;

// class Program
// {
//     static void Main()
//     {
//         int[] arr = { 1, 2, 3, -4, 2, 3, 4, 5, -6, -7, 1, 2, 3 };
//         int sum = 0;
//         bool inSequence = false;

//         Console.WriteLine("Sum of sequences of positive numbers:");

//         for (int i = 0; i < arr.Length; i++)
//         {
//             if (arr[i] > 0) 
//             {
//                 sum += arr[i];
//                 inSequence = true;
//             }
//             else if (inSequence) 
//             {
//                 Console.WriteLine(sum);
//                 sum = 0;
//                 inSequence = false;
//             }
//         }
//         if (inSequence)
//         {
//             Console.WriteLine(sum);
//         }
//     }
// }
