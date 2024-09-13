using System;


class VectorMath
{
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length || vector.Length < 2 || vector.Length > 3)
        {
            return -1;
        }

        double[] result = new double[vector1.Length];

        for (int i = 0; i < vector1.Length)
        {
            result[i] = Math.Round(vector1[i] + vector2[i]);
        }

        return result;
    }
}