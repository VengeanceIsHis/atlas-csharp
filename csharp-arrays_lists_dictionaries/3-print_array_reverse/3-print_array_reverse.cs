using System;
using System.Connections.Generic;

class Array
{
    public static void Reverse(int[] array)
    {
        int[] reversed = new int[array.Length];
        int j = 0;
        for (int i = array.Length; i > 0; i--)
        {
            reversed[j++] = array[i];
        }
        return reversed;
    }
}