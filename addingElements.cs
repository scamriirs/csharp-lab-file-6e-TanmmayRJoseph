//*Q1) write a program to add the elements of 2d matrix

using System;

class Program
{
    static void Main()
    {
        int[,] matrix = new int[3, 3];
        int sum = 0;

        Console.WriteLine("Enter the elements of the matrix:");
        
     
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Enter element at row {i}, column {j}: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                sum += matrix[i, j];  // Adding the element to sum
            }
        }
        Console.WriteLine("\nSum of all elements in the matrix: " + sum);
    }
}
