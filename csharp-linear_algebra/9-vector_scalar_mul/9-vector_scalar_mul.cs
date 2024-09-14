using System;


class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] result = new double[vector.Length]; 
        
        if (vector.Length < 2 || vector.Length > 3 || vector.Length == 0)
        {
            result[0] = -1;
        }

        else
        {
            for (int i = 0; i < vector.Length; i++)
            {
                result[i] = Math.Round(vector[i] * scalar);
            }
        }
        return result;
    }
}