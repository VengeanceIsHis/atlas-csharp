using System;
using System.Collections.Generic;

class Array
{
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
         if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Index out of range");
            return array; 
        }

        int[] newArray = (int[])array.Clone();

        newArray[index] = n;

        return newArray;
    }
}