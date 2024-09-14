using System;


class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] result = new double[vector.Length];
        
        if (vector.Length < 2 || vector.Length > 3)
        {
            result[0] = -1;
        }

        else
        {
            for (int i = 0; i < vector1.Length; i++)
            {
                result[i] = Math.Round(vector1[i] * scalar);
            }
        }
        return result;
    }
}