using System;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols)
        {
            return new double[,] { { -1 } };  // Return a matrix with -1 if the size is invalid
        }

        double cosangle = Math.Cos(angle);
        double sinangle = Math.Sin(angle);

        double[,] rotation = new double[2, 2]
        {
            { cosangle, -sinangle },
            { sinangle, cosangle}
        };

        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < cols; k++)
                {
                    result[i, j] += matrix[i, k] * rotation[k, j];
                }
            }
        }

        return result;
    }
}