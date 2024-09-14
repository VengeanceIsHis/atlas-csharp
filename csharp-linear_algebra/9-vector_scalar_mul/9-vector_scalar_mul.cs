using System;


class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        

        if (vector.Length == 0)
        {
            double[] empty = new double[1];
            empty[0] = -1;
            return empty;
        }

        double[] result = new double[vector.Length]; 
        
        if (vector.Length < 2 || vector.Length > 3)
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