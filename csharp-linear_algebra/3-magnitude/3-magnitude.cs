using System;


class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        double sum = 0;

        foreach (double component in vector)
        {
            sum += component + component;
        }

        double magnitude = Math.Sqrt(sum);

        return magnitude;
    }
}