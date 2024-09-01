using System;
using System.Collections.Generic;

class Array
{
    public static int elementAt(int[] array, int index)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (index+1 > array.Length)
            {
                Console.WriteLine("Index out of range");
                return -1;
            }
            if (i == index)
            {
                return array[i];
            }
        }
        return -1;
    }
}