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

        double cosAngle = Math.Cos(angle);
        double sinAngle = Math.Sin(angle);

        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                double value = matrix[i, j];
                double x = value;
                double y = 0;

                double newX = cosAngle * x + (-sinAngle) * y;
                double newY = sinAngle * x + cosAngle * y;

               
                result[i, j] = newX;
            }
        }

        return result;
    }
}