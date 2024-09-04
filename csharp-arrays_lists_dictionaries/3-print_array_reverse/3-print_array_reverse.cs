using System;
using System.Collections.Generic;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null)
        {
            Console.WriteLine();
        }
        else
        {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (i == 0)
            {
                Console.Write(array[i]);
            }
        Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
    }
}
