﻿using System;
namespace MyMath
{


public class Matrix
{
    public static int[,] Divide(int[,] matrix, int num)
    {
        if (num == 0)
        {
           Console.WriteLine("Num cannot be 0");
           return null;
        }

        else
        {

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j] / num;
                }
            }
            return result;
        }
    }
}
}