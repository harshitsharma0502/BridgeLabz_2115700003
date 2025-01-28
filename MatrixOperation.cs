using System;

class MatrixOperations
{
    // Method to create a random matrix of given size (rows x columns)
    public static int[,] CreateRandomMatrix(int rows, int columns)
    {
        Random random = new Random();
        int[,] matrix = new int[rows, columns];  // Initialize the matrix with given size
        // Fill the matrix with random values between 1 and 9
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = random.Next(1, 10); // Random numbers between 1 and 9
            }
        }
        return matrix;
    }

    // Method to display a matrix in a readable format
    public static void DisplayMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);  // Get number of rows
        int columns = matrix.GetLength(1);  // Get number of columns
        // Display each element in the matrix
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "\t");  // Display each element with a tab space
            }
            Console.WriteLine();  // Move to the next line after each row
        }
    }

    // Method to add two matrices of the same size
    public static int[,] AddMatrices(int[,] a, int[,] b)
    {
        int rows = a.GetLength(0);  // Get number of rows
        int columns = a.GetLength(1);  // Get number of columns
        int[,] result = new int[rows, columns];  // Initialize result matrix
        // Add corresponding elements of both matrices
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = a[i, j] + b[i, j];  // Add corresponding elements
            }
        }
        return result;
    }

    // Method to subtract matrix b from matrix a
    public static int[,] SubtractMatrices(int[,] a, int[,] b)
    {
        int rows = a.GetLength(0);  // Get number of rows
        int columns = a.GetLength(1);  // Get number of columns
        int[,] result = new int[rows, columns];  // Initialize result matrix
        // Subtract corresponding elements of matrix b from matrix a
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = a[i, j] - b[i, j];  // Subtract corresponding elements
            }
        }
        return result;
    }

    // Method to multiply two matrices
    public static int[,] MultiplyMatrices(int[,] a, int[,] b)
    {
        int rowsA = a.GetLength(0);  // Get number of rows of matrix a
        int columnsA = a.GetLength(1);  // Get number of columns of matrix a
        int columnsB = b.GetLength(1);  // Get number of columns of matrix b

        int[,] result = new int[rowsA, columnsB];  // Initialize result matrix
        // Perform matrix multiplication
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < columnsB; j++)
            {
                result[i, j] = 0;  // Initialize the current element to 0
                // Sum the products of corresponding elements
                for (int k = 0; k < columnsA; k++)
                {
                    result[i, j] += a[i, k] * b[k, j];  // Matrix multiplication formula
                }
            }
        }
        return result;
    }

    // Method to find the transpose of a matrix (swap rows and columns)
    public static int[,] TransposeMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);  // Get number of rows
        int columns = matrix.GetLength(1);  // Get number of columns
        int[,] transpose = new int[columns, rows];  // Initialize transpose matrix
        // Swap rows and columns
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                transpose[j, i] = matrix[i, j];  // Assign transposed value
            }
        }
        return transpose;
    }

    // Method to find the determinant of a 2x2 matrix
    public static int Determinant2x2(int[,] matrix)
    {
        return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];  // Determinant formula for 2x2 matrix
    }

    // Method to find the determinant of a 3x3 matrix
    public static int Determinant3x3(int[,] matrix)
    {
        // Determinant formula for 3x3 matrix
        return matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
             - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
             + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
    }

    // Method to find the inverse of a 2x2 matrix
    public static double[,] Inverse2x2(int[,] matrix)
    {
        int determinant = Determinant2x2(matrix);  // Get determinant
        if (determinant == 0)
        {
            throw new InvalidOperationException("Matrix is not invertible.");  // Matrix is not invertible if determinant is 0
        }
        double[,] inverse = new double[2, 2];  // Initialize inverse matrix
        // Calculate inverse of 2x2 matrix
        inverse[0, 0] = matrix[1, 1] / (double)determinant;
        inverse[0, 1] = -matrix[0, 1] / (double)determinant;
        inverse[1, 0] = -matrix[1, 0] / (double)determinant;
        inverse[1, 1] = matrix[0, 0] / (double)determinant;
        return inverse;
    }

    // Method to find the inverse of a 3x3 matrix
    public static double[,] Inverse3x3(int[,] matrix)
    {
        int determinant = Determinant3x3(matrix);  // Get determinant
        if (determinant == 0)
        {
            throw new InvalidOperationException("Matrix is not invertible.");  // Matrix is not invertible if determinant is 0
        }

        // Calculate adjoint matrix for 3x3
        double[,] adjoint = new double[3, 3];
        adjoint[0, 0] = Determinant2x2(new int[,] { { matrix[1, 1], matrix[1, 2] }, { matrix[2, 1], matrix[2, 2] } });
        adjoint[0, 1] = -Determinant2x2(new int[,] { { matrix[1, 0], matrix[1, 2] }, { matrix[2, 0], matrix[2, 2] } });
        adjoint[0, 2] = Determinant2x2(new int[,] { { matrix[1, 0], matrix[1, 1] }, { matrix[2, 0], matrix[2, 1] } });

        adjoint[1, 0] = -Determinant2x2(new int[,] { { matrix[0, 1], matrix[0, 2] }, { matrix[2, 1], matrix[2, 2] } });
        adjoint[1, 1] = Determinant2x2(new int[,] { { matrix[0, 0], matrix[0, 2] }, { matrix[2, 0], matrix[2, 2] } });
        adjoint[1, 2] = -Determinant2x2(new int[,] { { matrix[0, 0], matrix[0, 1] }, { matrix[2, 0], matrix[2, 1] } });

        adjoint[2, 0] = Determinant2x2(new int[,] { { matrix[0, 1], matrix[0, 2] }, { matrix[1, 1], matrix[1, 2] } });
        adjoint[2, 1] = -Determinant2x2(new int[,] { { matrix[0, 0], matrix[0, 2] }, { matrix[1, 0], matrix[1, 2] } });
        adjoint[2, 2] = Determinant2x2(new int[,] { { matrix[0, 0], matrix[0, 1] }, { matrix[1, 0], matrix[1, 1] } });

        double[,] inverse = new double[3, 3];
        // Divide adjoint by the determinant to get inverse
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                inverse[i, j] = adjoint[i, j] / determinant;
            }
        }
        return inverse;
    }

    // Main method demonstrating matrix operations
    public static void Main(string[] args)
    {
        // Example: Create two matrices and perform operations
        int[,] matrixA = CreateRandomMatrix(3, 3);
        int[,] matrixB = CreateRandomMatrix(3, 3);

        Console.WriteLine("Matrix A:");
        DisplayMatrix(matrixA);  // Display Matrix A
        Console.WriteLine("Matrix B:");
        DisplayMatrix(matrixB);  // Display Matrix B

        // Perform matrix addition, subtraction, multiplication, etc.
        Console.WriteLine("Matrix A + B:");
        DisplayMatrix(AddMatrices(matrixA, matrixB));  // Add matrices

        Console.WriteLine("Matrix A - B:");
        DisplayMatrix(SubtractMatrices(matrixA, matrixB));  // Subtract matrices

        Console.WriteLine("Matrix A * B:");
        DisplayMatrix(MultiplyMatrices(matrixA, matrixB));  // Multiply matrices

        Console.WriteLine("Transpose of Matrix A:");
        DisplayMatrix(TransposeMatrix(matrixA));  // Display transpose of Matrix A

        // Display the determinants for 3x3 and 2x2 matrices
        Console.WriteLine("Determinant of Matrix A 3x3 : " + Determinant3x3(matrixA));
        Console.WriteLine("Determinant of Matrix A 2x2 : " + Determinant2x2(matrixA));

        
        // Attempt to display the inverse of Matrix A (both 3x3 and 2x2)
        Console.WriteLine("Inverse of Matrix A 3x3 :");
        double[,] inverse = Inverse3x3(matrixA);
        for (int i = 0; i < 3; i++)
        {
        for (int j = 0; j < 3; j++)
        {
        Console.Write("{0:F2}\t", inverse[i, j]);  // Display inverse with 2 decimal places
        }
        Console.WriteLine();
        }

        Console.WriteLine("Inverse of Matrix A 2x2 :");
        double[,] inverse1 = Inverse2x2(matrixA);
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write("{0:F2}\t", inverse1[i, j]);  // Display inverse with 2 decimal places
            }
            Console.WriteLine();
        }
    }
}
