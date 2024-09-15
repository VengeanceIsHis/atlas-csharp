using System;


class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] shear;
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] result;

        if (rows == cols || rows == 2 || direction == 'x' || direction == 'y')
        {
            shear = new double[2, 2];
            shear[0, 0] = 1;
            shear[1, 1] = 1;
            if (direction == 'x')
            {
            shear[0, 1] = factor;
            shear[1, 0] = 0;
            }
            else
            {
                shear[0, 1] = 0;
                shear[1, 0] = factor;
            }

            result = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < cols; k++)
                    {
                        result[i, j] += shear[i, k] * matrix[k, j];
                    }
                }
            }

        }

        else
        {
            return new double[,] { { -1 } };
        }
        return result;
    }
}