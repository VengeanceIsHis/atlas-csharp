using System;
using System.Collections.Generic;

class Array
{
    public static int[] CreatePrint(int size)
    {
        List<int> numbers = new List<int>();
        if (size >= 0)
        {
        for (int i = 0; i < size; i++)
        {
            if (size == 0)
            {
                pass;
            }
            else
            {
            numbers.Add(i);
            if (i == size - 1)
            {
                Console.WriteLine(i);
            }
            else
            {
            Console.Write(i + " ");
            }
        }
        }
        int[] result = numbers.ToArray();
        return result;
        }
        else
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
    }
}