using System;

class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        // Validate matrix dimensions
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Check if the matrix is 2x2
        if (rows != 2 || cols != 2)
        {
            return new double[,] { { -1 } }; // Return error matrix
        }

        // Define the shear matrix based on direction
        double[,] shearMatrix = new double[2, 2];
        shearMatrix[0, 0] = 1;
        shearMatrix[1, 1] = 1;

        if (direction == 'x')
        {
            shearMatrix[0, 1] = factor; // Apply shear in x-direction
            shearMatrix[1, 0] = 0; // No shear in y-direction
        }
        else if (direction == 'y')
        {
            shearMatrix[0, 1] = 0; // No shear in x-direction
            shearMatrix[1, 0] = factor; // Apply shear in y-direction
        }
        else
        {
            return new double[,] { { -1 } }; // Return error matrix for invalid direction
        }

        // Apply the shear transformation
        double[,] result = new double[2, 2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < 2; k++)
                {
                    result[i, j] += shearMatrix[i, k] * matrix[k, j];
                }
            }
        }

        return result;
    }
}