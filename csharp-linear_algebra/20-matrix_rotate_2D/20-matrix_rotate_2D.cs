using System;


class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double cosangle = Math.Cos(angle);
        double sinangle = Math.Sin(angle);

        double[,] rotation = new double[2, 2]
        {
            { cosangle, -sinangle },
            { sinangle, cosangle}
        };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);  
        double[,] result = new double[rows, cols];
        if (cols < 2 || cols >= 3)
        {
            double[,] check = new double[1, 1];
            check[0, 0] = -1;
            return check;
        }

         for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                double value = matrix[i, j];
                double x = value;
                double y = 0;

                double newX = rotation[0, 0] * x + rotation[0, 1] * y;
                double newY = rotation[1, 0] * x + rotation[1, 1] * y;

                result[i, j] = newX;
            }
        }

        return result;
    }
}