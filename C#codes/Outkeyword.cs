//* Q1) write a program to show the use of out keyword

// using System;
// class OutKeyword
// {
//     static void GetParts(double num, out int intPart, out double fracPart)
//     {
//         intPart = (int)num;
//         fracPart = num - intPart;
//     }
//     static void Main()
//     {
//         Console.Write("Enter a decimal number: ");
//         double num = Convert.ToDouble(Console.ReadLine());
//         int integerPart;
//         double fractionalPart;
//         GetParts(num, out integerPart, out fractionalPart);
//         Console.WriteLine("Integer part: " + integerPart);
//         Console.WriteLine("Fractional part: " + fractionalPart);
//     }
// }
