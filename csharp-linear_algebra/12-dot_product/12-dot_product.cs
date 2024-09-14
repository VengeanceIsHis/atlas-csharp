using System;


class VectorMath
{
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        double[] result = new double[vector1.Length];
        if (vector1.Length != vector2.Length || vector1.Length < 2 || vector1.Length > 3)
        {
            result[0] = -1;
        }

        else
        {
        for (int i = 0; i < vector1.Length; i++)
        {
            result[i] = Math.Round(vector1[i] * vector2[i]);
        }
        }

        return result;
    }
}