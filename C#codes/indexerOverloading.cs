// // Code to demonstrate overloading of indexers in C#
// using System;

// class SampleCollection
// {
//     private string[] data = new string[5];

//     // First indexer (integer-based)
//     public string this[int index]
//     {
//         get
//         {
//             if (index >= 0 && index < data.Length)
//                 return data[index];
//             else
//                 throw new IndexOutOfRangeException("Invalid index!");
//         }
//         set
//         {
//             if (index >= 0 && index < data.Length)
//                 data[index] = value;
//             else
//                 throw new IndexOutOfRangeException("Invalid index!");
//         }
//     }

//     // Overloaded indexer (string-based)
//     public string this[string index]
//     {
//         get
//         {
//             return Array.Find(data, element => element == index) ?? "Not Found";
//         }
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         SampleCollection collection = new SampleCollection();

//         // Using integer indexer
//         collection[0] = "Apple";
//         collection[1] = "Banana";
//         collection[2] = "Cherry";

//         Console.WriteLine(collection[0]); // Output: Apple
//         Console.WriteLine(collection[1]); // Output: Banana

//         // Using string indexer
//         Console.WriteLine(collection["Banana"]);  // Output: Banana
//         Console.WriteLine(collection["Mango"]);   // Output: Not Found
//     }
// }
