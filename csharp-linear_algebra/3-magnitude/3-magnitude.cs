using System;


class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.Length < 2 || vector.Length > 3)
        {
            return -1;
        }
        double sum = 0;

        foreach (double component in vector)
        {
            sum += component * component;
        }

        double magnitude = Math.Sqrt(sum);

        return magnitude;
    }
}