using System;
using System.Collections.Generic;

class Array
{
    public static int[] CreatePrint(int size)
    {
        List<int> numbers = new List<int>();
        if (size >= 0)
        {
        for (int i = 0; i < size + 1; i++)
        {
            if (size == 0)
            {
                Console.WriteLine();
            }
            else
            {
            numbers.Add(i);
            Console.Write(i);
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