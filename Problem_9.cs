using System;

class MultiDimensionalArray
{
    public static void Main(string[] args)
    {
        // Take user input for rows and columns
        Console.WriteLine("Enter the number of rows:");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the number of columns:");
        int cols = Convert.ToInt32(Console.ReadLine());

        // Initialize the 2D array
        int[,] matrix = new int[rows, cols];

        // Take user input for 2D array elements
        Console.WriteLine("Enter the elements of the 2D array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine("Enter element at position [" + i + "][" + j + "]:");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Initialize the 1D array
        int[] singleArray = new int[rows * cols];
        int index = 0;

        // Copy elements from 2D array to 1D array
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                singleArray[index] = matrix[i, j];
                index++;
            }
        }

        // Display the 2D array
        Console.WriteLine("\n2D Array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Display the 1D array
        Console.WriteLine("\n1D Array:");
        foreach (int element in singleArray)
        {
            Console.Write(element + " ");
        }
    }
}