using System;
using System.Text;

class MatrixBinarySearch
{
    static void Main()
    {
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        Console.WriteLine("Enter the matrix elements row-wise:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.Write("Enter the target value to search: ");
        int target = int.Parse(Console.ReadLine());

        StringBuilder result = new StringBuilder();
        int[] position = SearchInMatrix(matrix, rows, cols, target);

        if (position[0] == -1)
            result.Append("Target not found in the matrix.");
        else
            result.Append("Target found at row ").Append(position[0] + 1)
                  .Append(", column ").Append(position[1] + 1);

        Console.WriteLine(result.ToString());
    }

    static int[] SearchInMatrix(int[,] matrix, int rows, int cols, int target)
    {
        int left = 0, right = rows * cols - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int midValue = matrix[mid / cols, mid % cols];

            if (midValue == target)
                return new int[] { mid / cols, mid % cols };
            else if (midValue < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return new int[] { -1, -1 }; // Not found
    }
}
