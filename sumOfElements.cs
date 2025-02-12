//*Q1) write a program to find sum of  elememts of  2d matrix in C#

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, cols];
        int sum = 0;

        Console.WriteLine("\nEnter the elements of the matrix:");
        
       
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Enter element at row {i}, column {j}: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                sum += matrix[i, j];  
            }
        }
        Console.WriteLine($"\nSum of all elements in the matrix: {sum}");
    }
}
