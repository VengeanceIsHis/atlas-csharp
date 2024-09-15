using System;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols)
        {
            return new double[,] { { -1 } };
        }

        double cosAngle = Math.Round(Math.Cos(angle));
        double sinAngle = Math.Round(Math.Sin(angle));

        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                double x = matrix[i, j];
                double y = 0;

                double newX = cosAngle * x - sinAngle * y;
                double newY = sinAngle * x + cosAngle * y;

                
                result[i, j] = newX;
            }
        }

        return result;
    }
}