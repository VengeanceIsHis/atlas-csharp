using System;
using System.Collections.Generic;

class Array
{
    public static int elementAt(int[] array, int index)
    {
            if (index > array.Length - 1 || index < 0)
            {
                Console.WriteLine("Index out of range");
                return -1;
            }
            else
            {
                return array[index];
            }
    }
}