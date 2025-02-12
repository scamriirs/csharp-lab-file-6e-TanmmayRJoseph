//*Q1)write a program to find the square of a number using pass by value and pass by reference
// using System;

// class Program
// {
//     static void SquareByValue(int num)
//     {
//         num = num * num;
//         Console.WriteLine("Square (Pass by Value): " + num);
//     }
//     static void SquareByReference(ref int num)
//     {
//         num = num * num;
//         Console.WriteLine("Square (Pass by Reference): " + num);
//     }
//     static void Main()
//     {
//         int a = 5, b = 5;
//         SquareByValue(a);
//         Console.WriteLine("After Pass by Value, a = " + a); // Original value remains same
//         SquareByReference(ref b);
//         Console.WriteLine("After Pass by Reference, b = " + b); // Original value changes
//     }
// }
