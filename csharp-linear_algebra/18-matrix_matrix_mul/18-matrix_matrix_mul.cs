using System;


class MatrixMath
{
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);
        
         
        if (cols1 != rows2)
        {
            double[,] check = new double[1, 1];
            check[0, 0] = -1;
            return check;
        }
        
        double[,] result = new double[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for(int j = 0; j < cols2; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < cols1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return result;
    }
}