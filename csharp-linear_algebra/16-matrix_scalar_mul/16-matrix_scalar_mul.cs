using System;


class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        int rows1 = matrix.GetLength(0);
        int cols1 = matrix.GetLength(1);  
        if (cols1 < 2 || cols1 > 3)
        {
            double[,] check = new double[1, 1];
            check[0, 0] = -1;
            return check;
        }
        else
        {
            double[,] result = new double[rows1, cols1];
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    result[i, j] = matrix[i, j] * scalar;
                }
            }
            return result;
        }
    }
}