using System;


class MatrixMath
{
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);
        
        double[,] result = new double[vector.Length]; 
        if (rows1 != rows2 || cols1 != cols2 || rows1 < 2 || rows1 > 3)
        {
            result[0, 0] = -1;
        }

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols1; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return result;
    }
}